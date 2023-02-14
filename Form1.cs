namespace WinForms_1_
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
        public string RoomType { get; set; }

        public void CheckRoomType()
        {
            if (economRadioButon.Checked)
                RoomType = "Econom";
            else if (standartRadioButton.Checked)
                RoomType = "Standart";
            else if (luxRadioButton.Checked)
                RoomType = "Lux";
            else
                RoomType = "typeNotSelected";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckRoomType();

            MessageBox.Show(
                $"Name: {nameBox.Text}\n" +
                $"Surname: {surnameBox.Text}\n" +
                $"Contact Information: {phoneTextBox.Text} \n" +
                $"Count of people: {peopleUpDown.Value}\n" +
                $"Room type: {RoomType}\n" +
                $"Special notes: {notesText.Text} \n" +
                $"Date: {dateTimePicker1.Value}"
                );
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            surnameBox.Clear();
            phoneTextBox.Clear();
            peopleUpDown.Value = 0;
            economRadioButon.Checked = false;
            standartRadioButton.Checked = false;
            luxRadioButton.Checked = false;
            notesText.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void policyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (policyCheckBox.Checked)
                orderButton.Enabled = true;
            else
                orderButton.Enabled = false;
        }
    }
}