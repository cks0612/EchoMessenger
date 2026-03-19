using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            string typed_msg;

            typed_msg = txtbx.Text.Trim(); ;

            string timeStamp = DateTime.Now.ToString("[HH:mm:ss]");
            string message = timeStamp + " " + typed_msg;


            if (string.IsNullOrWhiteSpace(typed_msg))
            {
                return;
            }

            lstbx.Items.Add(typed_msg);

            txtbx.Clear();

            txtbx.Focus();

        }

        private void btn_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtbx_KeyDown(object sender, KeyEventArgs e)
        {
            string typed_msg;

            typed_msg = txtbx.Text.Trim(); ;

        

            if (e.KeyCode == Keys.Enter)
            {
                string timeStamp = DateTime.Now.ToString("[HH:mm:ss]");
                string message = timeStamp + " " + typed_msg;

                if (string.IsNullOrWhiteSpace(typed_msg))
                {
                    return;
                }

                lstbx.Items.Add(message);

                txtbx.Clear();

                txtbx.Focus();

            }
        }

        private void dks(object sender, EventArgs e)
        {

        }
    }
}
