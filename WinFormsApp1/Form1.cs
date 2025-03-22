namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static string Student_Name = " ";
        public static string Roll_ = " ";
        public static string Reg_Id = " ";
        public static string Semester_ = " ";
        public static string Blood_Group_ = " ";
        public static string Gender_ = " ";
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string roll = txtRoll.Text;
            int reg = int.Parse(txtId.Text);
            string semester = txtSemester.Text;
            string blood = txtBlood.Text;

            Student_Name = txtName.Text;
            Roll_ = txtRoll.Text;
            Reg_Id = txtId.Text;
            Semester_ = txtSemester.Text;
            Blood_Group_ = txtBlood.Text;
            Gender_ = rbtnmale.Text;
            string gender;
            if (rbtnmale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            MessageBox.Show("Student Name:" + name + "Roll:" + roll + "Reg:" + reg + "Semester:" + semester + "blood goup:" + blood + "gender:" + gender);

            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
