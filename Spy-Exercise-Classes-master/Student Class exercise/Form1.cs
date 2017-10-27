using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Mime;
using System.Windows.Forms;
using Student_Class_exercise.Business;

namespace Student_Class_exercise
{
    public partial class Form1 : Form
    {
        //create objects and give a default spy that will be overwritten
        Spy myDefaultSpy = new Double01();
        Agency myAgency = new Agency();

        public Form1()
        {
            InitializeComponent();
            cbspylevel.SelectedIndex = 0; //Give option
            ChooseSpyLevel();
        }

        private void BtnCreateNewSpyClick(object sender, EventArgs e)
        {
            LoadSpy();
            //let you save the spy after you have made it
            btnSaveSpy.Visible = true;
        }

        private void LoadSpy()
        {
            lbxSpy.Items.Clear();

            //join the spy to the agency
            myDefaultSpy.Agency = myAgency;
            //add the code name and others from the form
            myDefaultSpy.CodeName = txtCodeName.Text;
            myDefaultSpy.Agency.Country = txtAgencyCountry.Text;
            myDefaultSpy.Agency.AgencyName = txtAgencyName.Text;
            myDefaultSpy.Agency.NumberOfAgents = Convert.ToInt32(txtNumberOfAgents.Text);

            FillListBox();

            //work out the age
            lbxSpy.Items.Add("Spy is " + myDefaultSpy.yearsold(dtpDOB.Value) + " years old");

            //work out how long since seen
            lbxSpy.Items.Add(myDefaultSpy.DaysSincelastSeen(dtpLastSeen.Value) + " days last seen");
            //How many agents in the spy group
            lbxSpy.Items.Add("There are " + myDefaultSpy.Agency.NumberOfAgents + " spies");
        }

        private void FillListBox()
        {
            lbxSpy.Items.Add("Code name " + myDefaultSpy.CodeName);
            lbxSpy.Items.Add("Agent can use a " + myDefaultSpy.KillAbility);
            lbxSpy.Items.Add("Agent weapon is a " + myDefaultSpy.Weapon);
            lbxSpy.Items.Add("Home " + myDefaultSpy.Home());
            lbxSpy.Items.Add(myDefaultSpy.Agency.Country);
            }


        public void ChooseSpyLevel()
        {
            //select a level of spy and instantiate it
            var MyChosenSpy = Factory.GetASpy(cbspylevel.SelectedIndex);
            //pass across the values to the default spy
            myDefaultSpy = MyChosenSpy;
            //Pass across the agency (have to otherwise it doesn't work)
            myDefaultSpy.Agency = myAgency;
            //empty the Listbox
            lbxSpy.Items.Clear();
            //see it on the listbox with default settings
            FillListBox();
        }

        private void cbspylevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChooseSpyLevel();
        }
        //save your spy details
        private void BtnSaveSpy_Click(object sender, EventArgs e)
        {
            //create and fill a list of data
            List<string> FileData = new List<string>();

            foreach (string line in lbxSpy.Items)
            {
                FileData.Add(line);
            }

         //print out if there is a codename as it will be used as the filename

            if (myDefaultSpy.CodeName != null) {
                //get the filename
                string filename = myDefaultSpy.CodeName;
                //get the file path
                //  string path = Application.StartupPath + @"\" + filename + ".txt";


                //FileOperations.SaveFile(path, FileData);
                //save data in Data Project
                DataFramework.FileOperations.SaveFile(filename, FileData);
                btnSaveSpy.Visible = false;
                MessageBox.Show("File named " + filename + ".txt" + " has been saved");
            } else {
                MessageBox.Show("Cannot save until you have a Code Name");
            }
        }

        private void btnLoadFiles_Click(object sender, EventArgs e)
        {
           lbxSpy.Items.Clear();
            String Path = Application.StartupPath + @"\";
            lbxSpy.Items.AddRange(DataFramework.FileOperations.ListAllFiles(Path).ToArray()); 
            //FileOperations.ListAllFiles().ToArray());

        }
        //load file based on selected file name
        private void lbspy_SelectedIndexChanged(object sender, EventArgs e)
        {
          try
            {//get the name you click on
                string ChosenFileName = Convert.ToString(lbxSpy.SelectedItem);
                lbxSpy.Items.Clear();
                //load the file with that name
                string filename = Application.StartupPath + @"\" + ChosenFileName;
                lbxSpy.Items.AddRange(DataFramework.FileOperations.ReturnFileData(filename).ToArray());
            } catch (Exception exception) {
                lbxSpy.Items.Add("Error Occured");
              MessageBox.Show(exception.ToString());
            }

        }

       
    }

}
