
namespace View.Frameworks.Controllers
{
    public static class FormButtonHelper
    {
        public static void SetInitialState(Button btnPost, Button btnPut, Button btnDelete)
        {
            btnPost.Enabled = true;
            btnPut.Enabled = false;
            btnDelete.Enabled = false;
        }

        public static void EnableEditAndDelete(Button btnPost, Button btnPut, Button btnDelete)
        {
            btnPost.Enabled = false;
            btnPut.Enabled = true;
            btnDelete.Enabled = true;
        }
    }
}
