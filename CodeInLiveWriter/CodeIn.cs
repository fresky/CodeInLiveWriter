using WindowsLive.Writer.Api;
using System.Windows.Forms;

namespace CodeInLiveWriter
{
    [InsertableContentSource("Insert Code", SidebarText = "Insert Code"), WriterPlugin("FF44E78D-FEEF-40a2-BAC9-38A119273EE4", "CodeInLiveWriter")]
    public class CodeIn : ContentSource
    {
        public override DialogResult CreateContent(IWin32Window dialogOwner, ref string content)
        {
            DialogResult dialogResult;
            using (CodeInForm codeForm = new CodeInForm())
            {
                dialogResult = codeForm.ShowDialog(dialogOwner);
                if (dialogResult == DialogResult.OK)
                {
                    content = codeForm.GetHtmlCode();
                }
            }
            return dialogResult;
        }
    }
}
