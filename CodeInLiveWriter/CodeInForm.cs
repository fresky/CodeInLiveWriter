using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Web;

namespace CodeInLiveWriter
{
    public partial class CodeInForm : Form
    {
        private string m_HtmlCode = string.Empty;

        public CodeInForm()
        {
            InitializeComponent();

            initLanguage();

            initStyle();
        }

        private void initStyle()
        {
            comboBox_Style.Items.Clear();
            comboBox_Style.Items.Add("vs");
            comboBox_Style.Items.Add("colorful");
            comboBox_Style.Items.Add("emacs");
            comboBox_Style.Items.Add("vim");
            loadFromConfig(comboBox_Style, @"Plugins\CodeInLiveWriterStyle.txt");

            comboBox_Style.SelectedIndex = 0;
        }

        private void initLanguage()
        {
            comboBox_Language.Items.Clear();
            comboBox_Language.Items.Add("c#");
            comboBox_Language.Items.Add("c++"); 
            comboBox_Language.Items.Add("java");
            comboBox_Language.Items.Add("python");
            comboBox_Language.Items.Add("ruby");
            comboBox_Language.Items.Add("c"); 
            comboBox_Language.Items.Add("sql");
            comboBox_Language.Items.Add("html");
            comboBox_Language.Items.Add("xml");
            comboBox_Language.Items.Add("batch");
            comboBox_Language.Items.Add("bash");

            loadFromConfig(comboBox_Language, @"Plugins\CodeInLiveWriterLanguage.txt");

            comboBox_Language.SelectedIndex = 0;
        }

        private void loadFromConfig(ComboBox comboBoxStyle, string config)
        {
            try
            {
                using (StreamReader sr = new StreamReader(config))
                {
                    while (!sr.EndOfStream)
                    {
                        string language = sr.ReadLine().Trim();
                        if (!comboBoxStyle.Items.Contains(language))
                        {
                            comboBoxStyle.Items.Add(language);
                        }
                    }
                }
            }
            catch
            {
            }
        }

        public string GetHtmlCode()
        {
            return m_HtmlCode;
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            m_HtmlCode = getHtmlStyleCode(
                comboBox_Language.SelectedItem.ToString(),
                textBox_Code.Text.Trim(),
                checkBox_ShowLine.Checked,
                comboBox_Style.SelectedItem.ToString());
            DialogResult = DialogResult.OK;
        }

        private string getHtmlStyleCode(string language, string code, bool showline, string style)
        {
            try
            {
                HttpWebRequest httpWebRequest = WebRequest.Create("http://hilite.me/api") as HttpWebRequest;
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";

                string parameters = string.Format("lexer={0}&code={1}&{2}&style={3}",
                                                  HttpUtility.UrlEncode(language),
                                                  HttpUtility.UrlEncode(code),
                                                  showline ? "&linenos=1" : "",
                                                  style);

                using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(parameters);
                }
                string result;
                using (WebResponse response = httpWebRequest.GetResponse())
                {
                    using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        result = streamReader.ReadToEnd();
                    }
                }
                return result;
            }
            catch
            {
                return code;
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
