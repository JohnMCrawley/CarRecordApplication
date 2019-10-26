using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRecordApplication
{       //namespace - BRACKET OPEN//
    public partial class CarRecordsApplication : Form
    {   //Class - BRACKET OPEN//
        //Connection-Variables//
        private OleDbConnection connection;     //Connection//
        OleDbCommand command;                   //Command//
        OleDbDataReader dataReader;
        //Variables//
        int orderNumber = 0;                    //Order index//
        string sql = "";                        //SQL string//
        string manufacturer = "";               //Manufacturer container//
        string model = "";                      //Model container//
        string colour = "";                     //Colour container//
        bool petrol = false;                   //Petrol container//
        double engineSize = 0.00;               //Engine Size container//



        public CarRecordsApplication()
        {
            //Connect to the database//
            connection = new OleDbConnection(@"Provider= Microsoft.ACE.OLEDB.12.0; Data Source= " + Application.StartupPath + "/CarRecords.accdb");
            //Initialize Components//
            InitializeComponent();
            //Disable button upon start
            btnSave.Enabled = false;
        }


        ///////////////////////////////////////////////////////////
        //                        RESET FORM                     //
        ///////////////////////////////////////////////////////////
        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();    //Call the reset form method//
        }

        ///////////////////////////////////////////////////////////
        //                    ADD RECORD TO DATABASE             //
        ///////////////////////////////////////////////////////////
        private void btnAddRecord_Click(object sender, EventArgs e)
        {       //Button Add - BRACKET OPEN//

            try
            {   //TRY: bracket OPEN//

                //open the connection
                connection.Open();

                //Configure the SQL query
                orderNumber = Int32.Parse(txtboxOrderNumber.Text);
                manufacturer = txtboxCarMan.Text;
                model = txtboxCarMod.Text;
                colour = txtboxCarCol.Text;
                petrol = checkboxPetrol.Checked;
                double.TryParse(txtboxEngineSize.Text, out engineSize);

                //SQL query//
                sql = "INSERT INTO Cars(orderNumber, Manufacturer , Model, Colour, Petrol, EngineSize)" + "VALUES (@orderNumber, @Manufacturer, @Model, @Colour, @Petrol, @EngineSize)";

                //Configure the command to use the connection with the sql query
                command = new OleDbCommand(sql, connection);
                command.Parameters.AddWithValue("@orderNumber", orderNumber);
                command.Parameters.AddWithValue("@Manufacturer", manufacturer);
                command.Parameters.AddWithValue("@Model", model);
                command.Parameters.AddWithValue("@Colour", colour);
                command.Parameters.AddWithValue("@Petrol", petrol);
                command.Parameters.AddWithValue("@EngineSize", engineSize);

                //execute the insert command
                command.ExecuteNonQuery();

                //Output that the data has been succesfully added//
                MessageBox.Show("Data has been succesfully added to the database!");
                //After inputting the data to the database, reset the form//
                ResetForm();

            }   //TRY: bracket CLOSE//
            catch (Exception ex)
            {   //CATCH: bracket OPEN//
                MessageBox.Show("Data has been unsuccesfully added!");      //Print out error//
            }   //CATCH: bracket CLOSE//
            finally
            {   //FINALLY: bracket OPEN//
                connection.Close();          //Close the connection
            }  //FINALLY: bracket CLOSE//



        }       //Button Add - BRACKET CLOSE//




        ///////////////////////////////////////////////////////////
        //                 DISPLAY RECORD BUTTONS                //
        ///////////////////////////////////////////////////////////

        //Button Display - display record contents//
        private void btnDisplay_Click(object sender, EventArgs e)
        {       //Button display - BRACKET OPEN//

            //Clear listbox before display information again. This ensure that there's no duplicates in the listbox//
            listboxDisplayRecords.Items.Clear();

            //TRY: to connect to the Database//
            try
            {   //TRY bracket: OPEN//

                //open the connection
                connection.Open();
                //Configure the SQL query
                sql = "SELECT * FROM Cars";

                //Create the command object to use the connection with the sql query
                command = new OleDbCommand(sql, connection);

                //Execute the SELECT command returning a data Reader
                dataReader = command.ExecuteReader();

                //Check if database has records and if so display//
                if(dataReader.HasRows)
                {
                    //Print out the data//
                    while (dataReader.Read())
                    {
                        //Display the data in the listbox//
                        listboxDisplayRecords.Items.Add(dataReader["OrderNumber"] + "\t" + dataReader["Manufacturer"] + "\t" + dataReader["Model"] + "\t" + dataReader["Colour"] + "\t" + dataReader["Petrol"] + "\t" + dataReader["EngineSize"]);
                    }
                }
                //ELSE if database doesn't has records display this message//
                else if (!dataReader.HasRows)
                {
                    MessageBox.Show("There is no records to display." + "\n" + "Please add a record to display some data.");

                }


            } //TRY bracket: CLOSE//
            catch (Exception ex)
            {   //CATCH bracket: OPEN//
                MessageBox.Show(ex.ToString());
            }   //CATCH bracket: OPEN//
            finally
            {   //FINALLY bracket: OPEN//
                //Close the connection
                connection.Close();
            }   //FINALLY bracket: OPEN//
        }       //Button display - BRACKET CLOSE//


        ///////////////////////////////////////////////////////////
        //                     EDIT RECORD BUTTON              //
        ///////////////////////////////////////////////////////////

        //Button Edit - Edit the record data//
        private void btnEdit_Click(object sender, EventArgs e)
        {       //Button Edit - BRACKET OPEN//

            //IF: Item is selected//
            if(listboxDisplayRecords.SelectedIndex != -1)
            {
                //Enable the Save Button//
                btnSave.Enabled = true;
                try
                {
                    //Open connection//
                    connection.Open();

                    //Variables//
                    string originaldata = listboxDisplayRecords.SelectedItem.ToString();
                    string[] temp = originaldata.Split();
                    int orderNumber = 0;


                    //Set values from listbox into textfields//
                    orderNumber = Int32.Parse(temp[0]);
                    txtboxOrderNumber.Text = temp[0];
                    txtboxCarMan.Text = temp[1];
                    txtboxCarMod.Text = temp[2];
                    txtboxCarCol.Text = temp[3];

                    //Check if the stored boolean is true or false and make the checkbox to the same value//
                    if (temp[4] == "True")
                    {
                        checkboxPetrol.Checked = true;
                    }
                    else if (temp[4] == "False")
                    {
                        checkboxPetrol.Checked = false;
                    }
                    txtboxEngineSize.Text = temp[5];

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                finally
                {
                    //Close connection//
                    connection.Close();
                }
            }
            //ELSE IF: Item is NOT selected//
            else
            {
                MessageBox.Show("Please select an item to edit.");
            }




        }       //Button Edit - BRACKET CLOSE//



        ///////////////////////////////////////////////////////////
        //                 DELETE RECORD BUTTONS                //
        ///////////////////////////////////////////////////////////
        //Button Delete Record - Delete the selected record//
        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {       //Button Delete - BRACKET OPEN//
         
            //IF: Item is selected//
            if (listboxDisplayRecords.SelectedIndex != -1)
            {
                //Variables//
                string originaldata = listboxDisplayRecords.SelectedItem.ToString();
                string[] temp = originaldata.Split();
                //Set values from listbox into textfields
                orderNumber = Int32.Parse(temp[0]);
                //SQL string//
                sql = "DELETE FROM Cars WHERE OrderNumber=@OrderNumber ";

                //Message dialog box//
                DialogResult dialogResult = MessageBox.Show("Do you really want to Delete this Record?:" + "\n\n" + "Manufacturer: " + manufacturer + "\n" + "Model: " + model + "\n" + "Colour: " + colour + "\n" + "Petrol: " + petrol + "\n" + "Engine Size: " + engineSize.ToString(), "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();  //Open connection//

                        for (int i = 0; i < listboxDisplayRecords.SelectedItems.Count; i++)
                        {

                            //Delete item from listbox//
                            listboxDisplayRecords.Items.Remove(listboxDisplayRecords.SelectedItems[i]);
                            //Delete item from Database//
                            command = new OleDbCommand(sql, connection);
                            command.Parameters.AddWithValue("@OrderNumber", orderNumber);
                            //Execute the delete of the record//
                            command.ExecuteNonQuery();
                        }
                        //Output message to the user that the item has been deleted//
                        MessageBox.Show("Item has been deleted!");
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.ToString());  //Show error if cannot be deleted
                    }
                    finally
                    {
                        connection.Close(); //Close connection//
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Item hasn't been deleted");
                }
            }
            //ELSE IF: Item is NOT selected//
            else
            {
                MessageBox.Show("Please select an item to delete");
            }

        }       //Button Delete - BRACKET CLOSE//


        ///////////////////////////////////////////////////////////
        //                    SAVE RECORD                  //
        ///////////////////////////////////////////////////////////
        private void btnSave_Click(object sender, EventArgs e)
        {       //Button Save - BRACKET OPEN//
            try
            {
                //Variables//
                string originaldata = listboxDisplayRecords.SelectedItem.ToString();
                string[] temp = originaldata.Split();
                //Set values from listbox into textfields
                orderNumber = Int32.Parse(temp[0]);



                //Open connection//
                connection.Open();


                //Assign the variables data from textbox//
                orderNumber = Int32.Parse(txtboxOrderNumber.Text);
                manufacturer = txtboxCarMan.Text;
                model = txtboxCarMod.Text;
                colour = txtboxCarCol.Text;
                petrol = checkboxPetrol.Checked;
                //Change boolean value//
                if(checkboxPetrol.Checked)
                {
                    petrol = true;
                }
                else
                {
                    petrol = false;
                }
                engineSize = double.Parse(txtboxEngineSize.Text);

                //This is my update query in which i am taking input from the user through windows forms and update the record//
                sql = "UPDATE Cars SET [Manufacturer]=@Manufacturer, [Model]=@Model, [Colour]=@Colour, [Petrol]=@Petrol, [EngineSize]=@EngineSize WHERE [OrderNumber]=@OrderNumber";

                 //Configure the command to use the connection with the sql query
                 command = new OleDbCommand(sql, connection);
                //update record//
                 command.Parameters.AddWithValue("@Manufacturer", manufacturer);
                 command.Parameters.AddWithValue("@Model", model);
                 command.Parameters.AddWithValue("@Colour", colour);
                 command.Parameters.AddWithValue("@Petrol", petrol);
                 command.Parameters.AddWithValue("@EngineSize", engineSize);
                 command.Parameters.AddWithValue("@OrderNumber", orderNumber);
                //execute the update command
                command.ExecuteNonQuery();

                 //Show the record has been updated//s
                 MessageBox.Show("Record has been updated!.");

                //Reset Form//
                ResetForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();//Connection closed her
                btnSave.Enabled = false;
            }
        }          //Button Save - BRACKET CLOSE//






        ///////////////////////////////////////////////////////////
        //                    RESET FORM METHOD                  //
        ///////////////////////////////////////////////////////////
        public void ResetForm()
        {
            txtboxOrderNumber.Text = "";           //Reset - Order Number //
            txtboxCarMan.Text = "";               //Reset - Textbox Car Man //
            txtboxCarMod.Text = "";               //Reset - Textbox Car Mod//
            txtboxCarCol.Text = "";               //Reset - Textbox Car Col//
            checkboxPetrol.Checked = false;         //Reset - Checkbox Petrol//
            txtboxEngineSize.Text = "";           //Reset - Textbox Engine Size//
        }






        ///////////////////////////////////////////////////////////
        //                          MENU                        //
        ///////////////////////////////////////////////////////////

        //Close the application//
        private void submenuClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Menu help//
        private void menuHelp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("To start using the software to use/add/store/edit/delete and display records you need to add records" +
                "\n\n" +
                "Step #1: Find the, 'Add Records' section in this program to the left side. Fill in the data in textboxes/checkbox and click, 'Add Record' button and if you want to clear all the textboxes of values click the, 'Reset Form' button" +
                "\n\n" +
                "Step #2: Once you add data to the database, click, 'Display' button to show the records" +
                 "\n\n" +
                "Step #3: If you made a mistake you can click the, 'Edit' button and edit the data accordingly. Once you're done press the, 'Save' button to save the data" +
                "\n\n" +
                "Step #4: If you don't want the data to be in the database anymore you can press the, 'Delete' button and it will delete it from the listbox and the database but you will be asked if you're sure if you want to delete it" 
                
                ,"Help"
                , MessageBoxButtons.OK);

   
        }

    }   //Class - BRACKET CLOSE//
}       //namespace - BRACKET CLOSE//
