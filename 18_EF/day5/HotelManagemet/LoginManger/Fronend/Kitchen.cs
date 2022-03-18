using HotelManagement.Context;
using HotelManagemet.Dapper;
using LoginManger.Context;
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

    public partial class Kitchen : Form
    {
        bool cleaning, towel, surprise;
        string queryString;
        int breakfast, lunch, dinner, foodBill;
        MyFrontTEndReservation context = new MyFrontTEndReservation();
        ReservationsManger manger = new ReservationsManger();
        public int primaryID;
        double totalBill;

        

        bool supply_status = false;
        public Kitchen()
        {
            InitializeComponent();
        }

        private void Bill_Click(object sender, EventArgs e)
        {
            FoodMenue food_menu = new();
            food_menu.checkBox4.Visible = false;
            food_menu.checkBox5.Visible = false;
            food_menu.checkBox6.Visible = false;


            food_menu.ShowDialog();

            breakfast = food_menu.BreakfastQ;
            lunch = food_menu.LunchQ;
            dinner = food_menu.DinnerQ;

            int bfast = 0, Lnch = 0, di_ner = 0;
            if (breakfast > 0)
            {
                bfast = 7 * breakfast;
            }
            if (lunch > 0)
            {
                Lnch = 15 * lunch;
            }
            if (dinner > 0)
            {
                di_ner = 15 * dinner;
            }
            foodBill += (bfast + Lnch + di_ner);
        }



        private void Kitchen_Load(object sender, EventArgs e)
        {
            loadGrid();
            listBoxFromDataBase();
        }

        private void supplyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            cleaningCheckBox.Checked = false;
            cleaningCheckBox.Text = "Cleaned";
            towelCheckBox.Checked = false;
            towelCheckBox.Text = "Toweled";
            surpriseCheckBox.Checked = false;
            surpriseCheckBox.Text = "Surprised";
            supply_status = true;
        }

        private void Kitchen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loadGrid()
        {
            try
            {
                var res = manger.GetAll().Where(R => R.CheckIn && !R.SupplyStatus).ToList();
                this.Grid.DataSource = res;
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error loading data", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
            }
        }


      
        private void resetEntries(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    resetEntries(control);
                }
            }

        }
        private void listBoxFromDataBase()
        {
            queueListBox.Items.Clear();
          
                try
                {
                var res = manger.GetAll().Where(R => R.CheckIn && !R.SupplyStatus).ToList();

                
                    
                    foreach(var item in res)
                    {queueListBox.Items.Add(item.Id + "  | " + item.FirstName + "  " + item.LastName + " | " + item.PhoneNumber);

                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
        private void queueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            resetEntries(this);
            string getQuerystring = queueListBox.Text.Substring(0, 4).Replace(" ", string.Empty);
            int id = int.Parse(getQuerystring);
            var res = manger.GetByID(id);

            
            try
            {
                
                    


                    if (res.Cleaning)
                    {
                        cleaning = true;
                        cleaningCheckBox.Checked = true;
                    }
                    else { cleaning = false; }

                    if (res.Towel)
                    {
                        towel = true;
                        towelCheckBox.Checked = true;
                    }
                    else { towel = false; }
                    if (res.SSurprise)
                    {
                    surprise = true; 
                        surpriseCheckBox.Checked = true;
                    }
                    else
                    {
                    surprise = false;
                    }

                    

                  
                    if (res.Lunch>0)
                    {
                        lunch = res.Lunch;
                        lunchTextBox.Text = Convert.ToString(lunch);
                    }
                    else
                    {
                        lunch = 0;
                        lunchTextBox.Text = "NONE";
                    }
                   
                    if (res.BreakFast>0)
                    {
                        breakfast = res.BreakFast;
                        breakfastTextBox.Text = Convert.ToString(breakfast);
                    }
                    else
                    {
                        breakfast = 0;
                        breakfastTextBox.Text = "NONE";
                    }
                    
                    if (res.Dinner>0)
                    {
                        dinner = res.Dinner;
                        dinnerTextBox.Text = Convert.ToString(dinner);
                    }
                    else
                    {
                        dinner = 0;
                        dinnerTextBox.Text = "NONE";
                    }

                    if (res.SupplyStatus)
                    {
                        supplyCheckBox.Checked = true;
                    }
                    else
                    {
                        supplyCheckBox.Checked = false;
                    }

                    firstNameTextBox.Text = res.FirstName;
                    lastNameTextBox.Text = res.LastName;
                    phoneNTextBox.Text = res.PhoneNumber;
                    roomTypeTextBox.Text = res.RoomType;
                    floorNTextBox.Text = res.RoomFloor;
                    roomNTextBox.Text = res.RoomNumber;
                    totalBill = res.TotalBill;
                    foodBill = res.FoodBill;
                    totalBill -= foodBill;
                    primaryID = res.Id;

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("COMBOBOX Selection: + " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (primaryID > 1000)
            {


                try
                {

                    var res = context.Reservations.Where(R => R.Id == primaryID).First();
                    res.TotalBill = totalBill;
                    res.FoodBill = foodBill;
                    res.BreakFast = breakfast;
                    res.Lunch = lunch;
                    res.Dinner = dinner;
                    res.SupplyStatus = supply_status;
                    res.Cleaning = cleaning;
                    res.Towel = towel;
                    res.SSurprise = surprise;

                    context.SaveChanges();

                    MessageBox.Show(this, "Entry successfully updated into database. For the UNIQUE USER ID of: " + "\n\n" +
                        " " + res.Id, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);


                    listBoxFromDataBase();
                    loadGrid();
                    resetEntries(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(this, "Selected ID doesn't exist.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

    }


}

