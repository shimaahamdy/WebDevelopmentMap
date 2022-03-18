
using HotelManagement.Context;
using HotelManagemet.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginManger.Fronend
{

    public partial class site : Form
    {
        MyFrontTEndReservation context = new MyFrontTEndReservation();
        BindingSource bindingSource1;
        BindingSource bindingSource2;

        public string towelS, cleaningS, surpriseS;

        public int foodBill;
        public string birthday = "";

        public string food_menu = "";
        public int totalAmount = 0;
        public bool checkin = false;
        public bool foodStatus = false;
        public int primartyID = 0;
        public bool taskFinder = false;
        public bool editClicked = false;
        public string FPayment, FCnumber, FcardExpOne, FcardExpTwo, FCardCVC;
        private double finalizedTotalAmount = 0.0;
        private string paymentType;
        private string paymentCardNumber;
        private string MM_YY_Of_Card;
        private string CVC_Of_Card;
        private string CardType;

        private int lunch = 0; private int breakfast = 0; private int dinner = 0;
        private bool cleaning; private bool towel;
        private bool surprise;

        public site()
        {
            InitializeComponent();

            CenterToScreen();
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today.AddDays(1);

            loadResvGrid();
            bindingSource1 = new BindingSource();
            var occList = context.Reservations.Where(R => R.CheckIn == true).ToList();
            bindingSource1.DataSource = occList;

            this.OccRoom.DataBindings.Add("Text", bindingSource1, "RoomNumber");
            this.occType.DataBindings.Add("Text", bindingSource1, "RoomType");
            this.occID.DataBindings.Add("Text", bindingSource1, "ID");
            this.occName.DataBindings.Add("Text", bindingSource1, "FirstName");
            this.occLastname.DataBindings.Add("Text", bindingSource1, "LastName");
            this.occPhone.DataBindings.Add("Text", bindingSource1, "PhoneNumber");

            bindingSource2 = new BindingSource();
            var occList2 = context.Reservations.Where(R => R.CheckIn == false).ToList();
            bindingSource2.DataSource = occList2;

            this.resRoom.DataBindings.Add("Text", bindingSource2, "RoomNumber");
            this.resType.DataBindings.Add("Text", bindingSource2, "RoomType");
            this.resID.DataBindings.Add("Text", bindingSource2, "ID");
            this.resName.DataBindings.Add("Text", bindingSource2, "FirstName");
            this.resLastname.DataBindings.Add("Text", bindingSource2, "LastName");
            this.resPhone.DataBindings.Add("Text", bindingSource2, "PhoneNumber");
            this.resEntry.DataBindings.Add("Text", bindingSource2, "ArrivalTime");
            this.resDep.DataBindings.Add("Text", bindingSource2, "LeavingTime");
            loadOccupationRooms();
            loadReservedRooms();
            setupRes();
            removeCheckedRooms();

            this.comboBox5.Visible = false;
            this.button5.Visible = false;
            this.button8.Visible = false;
            this.button7.Visible = false;


        }




        private void removeCheckedRooms()
        {
            var roonNumberList = context.Reservations.Where(R => R.CheckIn == true).Select(R => R.RoomNumber.ToString().Trim()).ToList();
            foreach (string roomList in roonNumberList)
            {
                if (comboBox3.Items.Contains(roomList))
                {

                    int temp = comboBox3.Items.IndexOf(roomList);
                    comboBox3.Items.RemoveAt(temp);
                }
            }
        }
        private void setupRes()
        {
            this.txtFirst.PlaceholderText = "First";
            this.txtLast.PlaceholderText = "Last";
            this.txtYear.PlaceholderText = "Year";
            this.txtPhone.PlaceholderText = "(999) 999-999";
            this.txtStreet.PlaceholderText = "Street address";
            this.txtSuite.PlaceholderText = "Apt./Suite";
            this.txtCity.PlaceholderText = "City";
            this.txtZip.PlaceholderText = "ZipCode";
            this.txtEmail.PlaceholderText = "first.last@example.com";
        }
        private void loadResvGrid()
        {
            try
            {
                context.Reservations.Load();
                this.Grid.DataSource = context.Reservations.Local.ToBindingList();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error loading data", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
            }
        }

        private void loadOccupationRooms()
        {
            


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.Equals("Single"))
            {
                totalAmount = 149;
                comboBox4.SelectedItem = "1";
            }
            else if (comboBox2.SelectedItem.Equals("Double"))
            {
                totalAmount = 299;
                comboBox4.SelectedItem = "2";
            }
            else if (comboBox2.SelectedItem.Equals("Twin"))
            {
                totalAmount = 349;
                comboBox4.SelectedItem = "3";
            }
            else if (comboBox2.SelectedItem.Equals("Duplex"))
            {
                totalAmount = 399;
                comboBox4.SelectedItem = "4";
            }
            else if (comboBox2.SelectedItem.Equals("Suite"))
            {
                totalAmount = 499;
                comboBox4.SelectedItem = "5";
            }
            int selectedTemp = 0;
            string selected;
            bool temp = int.TryParse(comboBox1.SelectedItem.ToString(), out selectedTemp);
            if (!temp)
            {
                MessageBox.Show(this, "Enter # of guests first", "Error parsing", MessageBoxButtons.OK);
            }
            else
            {
                selected = comboBox1.SelectedItem.ToString();
                selectedTemp = Convert.ToInt32(selected);
                if (selectedTemp >= 3)
                {
                    totalAmount += (selectedTemp * 5);
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Checked in";
                checkin = true;
            }
            else
            {
                checkin = false;
                checkBox1.Text = "Check in ?";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            button7.Visible = false;
            button8.Visible = false;
            comboBox5.Visible = false;
            resetSite();
        }
        private void resetSite()
        {
            try
            {

                comboBox5.Items.Clear();
                checkBox1.Checked = false;
                checkBox3.Checked = false;

                ClearAllComboBox(this);
                ClearAllTextBoxes(this);

                ComboBoxItemsFromDataBase();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void ComboBoxItemsFromDataBase()
        {
            try
            {
                var R = context.Reservations.Select(R => R).ToList();
                foreach (var item in R)
                {
                    string ID = item.Id.ToString();
                    string first_name = item.FirstName;
                    string last_name = item.LastName;
                    string phone_number = item.PhoneNumber;
                    comboBox5.Items.Add(ID + "  | " + first_name + "  " + last_name + " | " + phone_number);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ClearAllComboBox(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control == comboBox2)
                {
                    continue;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                if (control.HasChildren)
                {
                    ClearAllComboBox(control);
                }
            }
        }
        public void ClearAllTextBoxes(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    ClearAllTextBoxes(control);
                }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeCheckedRooms();
            string strID = comboBox5.Text.Substring(0, 4).Replace(" ", string.Empty);
            int ID = int.Parse(strID);
            try
            {
                taskFinder = true;
                var resList = context.Reservations.Where(R => R.Id == ID).ToList();
                foreach (var item in resList)
                {
                    comboBox3.Items.Add(item.RoomNumber);
                    comboBox3.SelectedItem = item.RoomNumber;

                    if (item.Cleaning) cleaning = true;
                    else cleaning = false;

                    if (item.Towel) towel = true;
                    else towel = false;

                    if (item.SSurprise) surprise = true;
                    else surprise = false;

                    FPayment = item.PaymentType;
                    FCnumber = item.CardNumber;
                    FCardCVC = item.CardCvc;
                    FcardExpOne = item.CardExp.Substring(0, item.CardExp.IndexOf('/'));
                    FcardExpTwo = item.CardExp.Substring(item.CardExp.Length - Math.Min(2, item.CardExp.Length));

                    this.dateTimePicker1.Value = Convert.ToDateTime(item.ArrivalTime);

                    dateTimePicker2.Value = Convert.ToDateTime(item.LeavingTime);
                    dateTimePicker1.Value.ToShortDateString();
                    dateTimePicker2.Value.ToShortDateString();


                    lunch = item.Lunch;
                    breakfast = item.BreakFast;
                    dinner = item.Dinner;
                    foodBill = item.FoodBill;
                    if (item.SupplyStatus)
                        checkBox3.Checked = true;
                    else checkBox3.Checked = false;

                    txtFirst.Text = item.FirstName;
                    txtLast.Text = item.LastName;
                    txtPhone.Text = item.PhoneNumber;
                    CGender.SelectedItem = item.Gender;
                    CMonth.SelectedItem = item.BirthDay.Substring(0, item.BirthDay.IndexOf('-'));




                    Cday.SelectedItem = item.BirthDay.Substring(item.BirthDay.IndexOf('-') + 1, 2);
                    txtYear.Text = item.BirthDay.Substring(item.BirthDay.Length - Math.Min(4, item.BirthDay.Length));

                    txtEmail.Text = item.EmailAddress;
                    comboBox1.SelectedItem = item.NumberGuest.ToString();
                    txtStreet.Text = item.StreetAddress;
                    txtSuite.Text = item.AptSuite;
                    txtCity.Text = item.City;
                    CState.SelectedItem = item.State;
                    txtZip.Text = item.ZipCode;
                    comboBox2.SelectedItem = item.RoomType.Replace(" ", string.Empty);
                    comboBox4.SelectedItem = item.RoomFloor.Replace(" ", string.Empty);
                    comboBox3.SelectedItem = item.RoomNumber.Replace(" ", string.Empty);


                    if (item.CheckIn)
                        checkBox1.Checked = true;

                    else
                        checkBox1.Checked = false;



                    primartyID = item.Id;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("COMBOBOX Selection: + " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            editClicked = true;
            this.comboBox5.Visible = true;
            this.button8.Visible = true;
            this.button8.Enabled = false;
            this.button7.Visible = false;
            dateTimePicker1.MinDate = new DateTime(2014, 4, 1);
            dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            dateTimePicker2.MinDate = new DateTime(2014, 4, 1);
            dateTimePicker2.CustomFormat = "MM-dd-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;

            button5.Visible = false;
            button8.Visible = true;
            button7.Visible = true;
            comboBox5.Visible = true;

            ComboBoxItemsFromDataBase();
            loadResvGrid();
            resetSite();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try

            {
                
                birthday = (CMonth.SelectedItem) + "-" + (Cday.SelectedIndex + 1) + "-" + txtYear.Text;
                var res = context.Reservations.Where(R => R.Id == primartyID).FirstOrDefault();
                res.FirstName = txtFirst.Text;
                res.LastName = txtLast.Text;
                res.BirthDay = birthday;
                res.Gender = CGender.SelectedItem.ToString();
                res.PhoneNumber = txtPhone.Text;
                res.EmailAddress = txtEmail.Text;
                res.NumberGuest = comboBox1.SelectedIndex + 1;
                res.StreetAddress = txtStreet.Text;
                res.AptSuite = txtSuite.Text;
                res.City = txtCity.Text;
                res.State = CState.SelectedItem.ToString();
                res.ZipCode = txtZip.Text;
                res.RoomType = comboBox2.SelectedItem.ToString();
                res.RoomFloor = comboBox4.SelectedItem.ToString();
                res.RoomNumber = comboBox3.SelectedItem.ToString();
                res.TotalBill = finalizedTotalAmount;
                res.PaymentType = paymentType;
                res.CardType = CardType;
                res.CardNumber = paymentCardNumber == null ? res.CardNumber : paymentCardNumber; ;
                res.CardExp = MM_YY_Of_Card==null?res.CardExp:CVC_Of_Card;
                res.CardCvc = CVC_Of_Card==null?res.CardCvc:CVC_Of_Card;
                res.ArrivalTime = dateTimePicker1.Value;
                res.LeavingTime = dateTimePicker2.Value;
                res.BreakFast = breakfast;
                res.CheckIn = checkin;
                res.Lunch = lunch;
                res.Dinner = dinner;
                res.SupplyStatus = foodStatus;
                res.Cleaning = cleaning;
                res.Towel = towel;
                res.SSurprise = surprise;
                res.FoodBill = foodBill;


                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ComboBoxItemsFromDataBase();

            resetSite();
            loadResvGrid();
            loadOccupationRooms();
            loadReservedRooms();

            removeCheckedRooms();

        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
                var res = context.Reservations.Where(R => R.Id == primartyID).FirstOrDefault();
                context.Reservations.Remove(res);

                MessageBox.Show(this, "Reservation For the UNIQUE USER ID of: " + "\n\n" +
            " " + primartyID + " is DELETED.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                context.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Selected ID doesn't exist." + ex.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }


            ComboBoxItemsFromDataBase();
            loadResvGrid();
            loadOccupationRooms();
            resetSite();
            loadReservedRooms();
            removeCheckedRooms();

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            Reservation res = new();
            birthday = (CMonth.SelectedItem) + "-" + (Cday.SelectedIndex + 1) + "-" + txtYear.Text;
            res.Id = context.Reservations.OrderBy(R => R.Id).Last().Id+126; //new id
            res.FirstName = txtFirst.Text;
            res.LastName = txtLast.Text;
            res.BirthDay = birthday;
            res.Gender = CGender.SelectedItem.ToString();
            res.PhoneNumber = txtPhone.Text;
            res.EmailAddress = txtEmail.Text;
            res.NumberGuest = comboBox1.SelectedIndex + 1;
            res.StreetAddress = txtStreet.Text;
            res.AptSuite = txtSuite.Text;
            res.City = txtCity.Text;
            res.State = CState.SelectedItem.ToString();
            res.ZipCode = txtZip.Text;
            res.RoomType = comboBox2.SelectedItem.ToString();
            res.RoomFloor = comboBox4.SelectedItem.ToString();
            res.RoomNumber = comboBox3.SelectedItem.ToString();
            res.TotalBill = finalizedTotalAmount;
            res.PaymentType = paymentType;
            res.CardType = CardType;
            res.CardNumber = paymentCardNumber;
            res.CardExp = MM_YY_Of_Card;
            res.CardCvc = CVC_Of_Card;
            res.ArrivalTime = dateTimePicker1.Value;
            res.LeavingTime = dateTimePicker2.Value;
            res.BreakFast = breakfast;
            res.CheckIn = checkin;
            res.Lunch = lunch;
            res.Dinner = dinner;
            res.SupplyStatus = foodStatus;
            res.Cleaning = cleaning;
            res.Towel = towel;
            res.SSurprise = surprise;
            res.FoodBill = foodBill;

            context.Reservations.Add(res);
            context.SaveChanges();
           
         
            ComboBoxItemsFromDataBase();
            loadResvGrid();
            resetSite();
            loadOccupationRooms();
            loadReservedRooms();
            removeCheckedRooms();
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FoodMenue food_menu = new();
        
            if (taskFinder)
            {
                if (breakfast > 0)
                {
                    food_menu.breakFast.Checked = true;
                    food_menu.numericUpDown1.Value = breakfast;
                }
                if (lunch > 0)
                {
                    food_menu.Lunch.Checked = true;

                    food_menu.numericUpDown2.Value = lunch;
                }
                if (dinner > 0)
                {
                    food_menu.dinner.Checked = true;
                    food_menu.numericUpDown3.Value = dinner;
                }
                if (cleaning)
                {
                    food_menu.checkBox5.Checked = true;
                }
                if (towel)
                {
                    food_menu.checkBox6.Checked = true;
                }
                if (surprise)
                {
                    food_menu.checkBox4.Checked = true;
                }
            }
            food_menu.ShowDialog();

            breakfast = food_menu.BreakfastQ;
            lunch = food_menu.LunchQ;
            dinner = food_menu.DinnerQ;

            cleaning = food_menu.Cleaning.Replace(" ", string.Empty) == "Cleaning" ? true : false;
            towel = food_menu.Towel.Replace(" ", string.Empty) == "Towels" ? true : false;

            surprise = food_menu.Surprise.Replace(" ", string.Empty) == "Sweetestsurprise" ? true : false;

            if (breakfast > 0 || lunch > 0 || dinner > 0)
            {
                int bfast = 7 * breakfast;
                int Lnch = 15 * lunch;
                int di_ner = 15 * dinner;
                foodBill = bfast + Lnch + di_ner;
            }
        }

        private void Bill_Click(object sender, EventArgs e)
        {
            if (breakfast == 0 && lunch == 0 && dinner == 0 && cleaning  && towel && surprise)
            {
                checkBox3.Checked = true;
            }
            button8.Enabled = true;

            Bill finalizebil = new Bill();
            finalizebil.totalAmountFromFrontend = totalAmount;
            finalizebil.foodBill = foodBill;
            if (taskFinder)
            {
                finalizebil.paymentComboBox.SelectedItem = FPayment.Replace(" ", string.Empty);
                finalizebil.phoneNComboBox.Text = FCnumber;
                finalizebil.month.SelectedItem = FcardExpOne;
                finalizebil.year.SelectedItem = FcardExpTwo;
                finalizebil.CVC.Text = FCardCVC;
            }

            finalizebil.ShowDialog();

            finalizedTotalAmount = finalizebil.FinalTotalFinalized;
            paymentType = finalizebil.PaymentType;
            paymentCardNumber = finalizebil.PaymentCardNumber;
            MM_YY_Of_Card = finalizebil.MM_YY_Of_Card1;
            CVC_Of_Card = finalizebil.CVC_Of_Card1;
            CardType = finalizebil.CardType1;

            if (!editClicked)
            {
                button5.Visible = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var Results = (from R in context.Reservations
                           where R.FirstName.Contains(this.txtTitle.Text) || R.Id.ToString().Contains(this.txtTitle.Text)
                           || R.LastName.Contains(this.txtTitle.Text)
                           select R
                             ).ToList();
            this.dataGridView1.DataSource = Results;
        }

        private void site_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loadReservedRooms()
        {
            

        }


        private void occP_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void occN_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource2.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource2.MoveLast();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
