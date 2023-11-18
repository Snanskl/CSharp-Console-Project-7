using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
{
    public partial class MainForm : Form
    {
        #region Fields area
        private BeautyManager beautyManager; //Declared but not initilize
        private string fileName = Application.StartupPath + "\\HealthyBeauty.txt";

        #endregion

        #region Program main functions 
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        private void InitializeGUI()
        {
            this.Text = "Healthy Beauty By Ploypailin Junker";
            beautyManager = new BeautyManager();

            productListBox.Items.Clear();
            makeupCheckBox.Checked = true;
            productNameTextBox.Text = string.Empty;

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd   HH:mm";
            ListBoxEnable();

            toolTip1.ShowAlways = true;
            
            UpdateGUI();
        }
        private void Form1_Load(object sender, EventArgs e) //Done
        {
            CenterToScreen();
        }
        private void UpdateGUI()
        { 
            productListBox.Items.Clear();

            string[] updateListBox = beautyManager.GetInfo();

            if (updateListBox != null)
            {
                productListBox.Items.AddRange(updateListBox);
            }
        }

        #endregion

        #region Program Button area
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)//Done
        {
            //This class is for exit event with a confirmation provided to a user.

            DialogResult dl = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dl == DialogResult.Yes)
            {
                Close();
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)//Done
        {
            InitializeGUI();
        }
        private void skincareCheckBox_CheckedChanged(object sender, EventArgs e)
        {
                //Set this enum in a property
                beautyManager.AccessBeautyDate.Product = ProductType.Skincare;
                InitializeSkincareListBox();
        }
        private void makeupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
                //Set this enum in a property
                //objectName.SetProperty (ProductType.Makeup)
                beautyManager.AccessBeautyDate.Product = ProductType.Makeup;
                InitializeMakeupListBox();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)//Done
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }
        private void openDataFileToolStripMenuItem_Click(object sender, EventArgs e)//Done??
        {
            string errMessage = "Please try again, Something went wrong while open the file.";

            bool validOpen = beautyManager.ReadDataToFile(fileName);

            if (!validOpen)
            {
                MessageBox.Show(errMessage, "Error!");
            }
            else
            { UpdateGUI(); }
        }
        private void saveDataFileToolStripMenuItem_Click(object sender, EventArgs e)//Done??
        {
            string errMessage = "Please try again, something went wrong while saving the file.";

            bool ValidSave = beautyManager.WriteDataToFile(fileName);

            if (!ValidSave)
            {
                MessageBox.Show(errMessage, "Error");
            }
            else
            {
                MessageBox.Show("Data save to file: " + Environment.NewLine + fileName);
            }

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            BeautyAndDate currentBeautyDate = ReadInput();
            
            if ((currentBeautyDate != null) && (!string.IsNullOrEmpty(productNameTextBox.Text)))
            {
                beautyManager.AddTask(currentBeautyDate);
                productNameTextBox.Text = string.Empty;
                UpdateGUI();

                if (skincareCheckBox.Checked)
                {
                    GenerateGentleSkincareIngrediens();
                    GenerateNeutralSkincareIngrediens();
                    GenerateIrritationSkincareIngrediens();
                }
                else if (makeupCheckBox.Checked)
                {
                    GenerateGentleMakeupIngrediens();
                    GenerateNeutralMakeupIngrediens();
                    GenerateIrritationMakeupIngrediens();
                }

                productIngrediensListbox.ClearSelected();
                ListBoxEnable();
            }
        }
        private void productListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //This is for when a user selected certain object then the infor for that
            //object will show up in a listbox
            int selectedIndex = productIngrediensListbox.SelectedIndex;

            if (selectedIndex != -1)
            {
                BeautyAndDate beautyDate = beautyManager.GetAt(selectedIndex);
                productNameTextBox.Text = beautyDate.ProductName;
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)//Done
        {
            int selectedIndex = productListBox.SelectedIndex;

            if (selectedIndex != -1)
            {
                DialogResult dlResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dlResult == DialogResult.Yes)
                {
                    beautyManager.DeleteTaskAt(selectedIndex);
                    UpdateGUI();
                    productNameTextBox.Text = string.Empty;
                    ListBoxEnable();
                }
            }
            else
            {
                MessageBox.Show("Select one option before you delete or edit.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        #endregion

        #region Manual method
        private string[] InitializeMakeupListBox()
        {
            productIngrediensLabel.Text = "Makeup ingrediens";

            string[] makeupElements = beautyManager.GetMakeupToString();

            foreach (string item in makeupElements)
            {
                productIngrediensListbox.Items.Add(item);
            }
            return makeupElements;
        }
        private string[] InitializeSkincareListBox()
        {
            productIngrediensLabel.Text = "Skincare ingrediens";

            string[] skincareElements = beautyManager.GetSkincareToString();

            foreach (string item in skincareElements)
            {
                productIngrediensListbox.Items.Add(item);
            }
            return skincareElements;
        }
        private void ListBoxEnable() //Done
        {
            if (productListBox.Items.Count >0)
            {
                productListBox.Enabled = true;
                editButton.Enabled = true;
                deleteButton.Enabled = true;
            }
            else
            {
                productListBox.Enabled = false;
                editButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }
        private void GenerateGentleSkincareIngrediens()
        {
                List<string> gentleSkincareIngrediens = beautyManager.AccessBeautyDate.GentleSkicncareIngrediens();

                foreach (string ingrediens in gentleSkincareIngrediens)
                {
                    gentleIngrediensListbox.Items.Add(ingrediens);
                }
        }
        private void GenerateNeutralSkincareIngrediens()
        {
                List<string> neutralSkincareIngrediens = beautyManager.AccessBeautyDate.NeutralSkincareIngrediens();

                foreach (string ingrediens in neutralSkincareIngrediens)
                {
                    neautralIngrediensListBox.Items.Add(ingrediens);
                }
        }
        private void GenerateIrritationSkincareIngrediens()
        {
            List<string> irritationSkincareIngreiens = beautyManager.AccessBeautyDate.IrritationSkincareIngrediens();

                foreach (string ingrediens in irritationSkincareIngreiens)
                {
                    badIngrediensListbox.Items.Add(ingrediens);
                }
        }
        private void GenerateGentleMakeupIngrediens()
        {
                List<string> gentleMakeupIngrediens = beautyManager.AccessBeautyDate.GentleMakeupIngrediens();

                foreach (string ingrediens in gentleMakeupIngrediens)
                {
                    gentleIngrediensListbox.Items.Add(ingrediens);
                }
        }
        private void GenerateNeutralMakeupIngrediens()
        {
                List<string> neutralMakeupIngrediens = beautyManager.AccessBeautyDate.GentleMakeupIngrediens();

                foreach (string ingrediens in neutralMakeupIngrediens)
                {
                    neautralIngrediensListBox.Items.Add(ingrediens);
                }
        }
        private void GenerateIrritationMakeupIngrediens()
        {
                List<string> irritationMakeupIngrediens = beautyManager.AccessBeautyDate.IrritationMakeupIngrediens();

                foreach (string ingrediens in irritationMakeupIngrediens)
                {
                    badIngrediensListbox.Items.Add(ingrediens);
                }
        }

        #endregion

        #region Read input area 
        private bool ReadMakeupIngrediens()
        {
            bool validMakeup = false;

            List<MakeupIngrediens> makeupIngrediens = new List<MakeupIngrediens>();

            foreach (var selectedItems in productIngrediensListbox.SelectedItems)
            {
                if (Enum.TryParse(selectedItems.ToString(), out MakeupIngrediens selectedIngredient))
                {
                    makeupIngrediens.Add(selectedIngredient);
                    validMakeup = true;
                }
            }
            beautyManager.AccessBeautyDate.MakeupIngrediensProperty = makeupIngrediens;

            return validMakeup;
        }
        private bool ReadSkinCreIngrediens()
        {
            //Since property of type Enum only accept one element at time which means that we 
            //need to instantiated separated listt for each enum to store multiple selection
            //We also have changed from a regular enum type property to a property that of List type
            //to be able to accept muötiple selection in a property
            bool validSkincare = false;

            List<SkincareIngrediens> skincareIngrediens = new List<SkincareIngrediens>();

            foreach (var selectedItems in productIngrediensListbox.SelectedItems)
            {
                if (Enum.TryParse(selectedItems.ToString(), out SkincareIngrediens selectedIngrediens))
                {
                    skincareIngrediens.Add(selectedIngrediens);
                    validSkincare = true;
                }
            }
            beautyManager.AccessBeautyDate.SkincareIngrediensProperty = skincareIngrediens;

            return validSkincare;
        }
        private BeautyAndDate ReadInput()
        {
            //Instantiated a whole new object from BeautyAndDate class
            BeautyAndDate currentBeautyDate = new BeautyAndDate();

            string productName = productNameTextBox.Text;

            if (!string.IsNullOrEmpty(productName))
            {
                //Check if productName is not empty or null then send name and expiration date
                //to property in BeautyAndDate class
                currentBeautyDate.ProductName = productName;
                currentBeautyDate.Date = dateTimePicker1.Value;

                if (makeupCheckBox.Checked)
                {
                    ReadMakeupIngrediens();
                }
                else if (skincareCheckBox.Checked)
                {
                    ReadSkinCreIngrediens();
                }
            }
            else
            {
                MessageBox.Show("Please enter a correct name of the propduct", "Oops!", MessageBoxButtons.OK,MessageBoxIcon.Information );
            }
            return currentBeautyDate;
        }



        #endregion


    }
}
