using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageUploadDisplayApp
{
    public partial class Form1 : Form
    {
        private DataTable imageTable = new DataTable();

        private bool ValidateInput()
        {
            if (txtImageId.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the Image ID.",
                                "Missing Image ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtImageId.Focus();
                return false;
            }

            if (txtImageTitle.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the Image Title.",
                                "Missing Image Title",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtImageTitle.Focus();
                return false;
            }

            if (txtImagePath.Text.Trim() == "")
            {
                MessageBox.Show("Please select an image file.",
                                "Missing Image",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                btnBrowse.Focus();
                return false;
            }

            if (!File.Exists(txtImagePath.Text.Trim()))
            {
                MessageBox.Show("The selected image file does not exist.",
                                "File Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }
        private bool ImageIdExists(string imageId)
        {
            foreach (DataRow row in imageTable.Rows)
            {
                if (row["Image ID"].ToString().Equals(imageId, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
        private void ClearInputFields()
        {
            txtImageId.Clear();
            txtImageTitle.Clear();
            txtImagePath.Clear();

            picImage.Image = null;

            txtImageId.Focus();
        }

        private void picImage_Click(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            imageTable.Columns.Add("Image ID", typeof(string));
            imageTable.Columns.Add("Image Title", typeof(string));
            imageTable.Columns.Add("Image Path", typeof(string));
            imageTable.Columns.Add("Date Added", typeof(string));

            dgvImages.DataSource = imageTable;

            txtImageId.Focus();

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Select Image";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = openFileDialog.FileName;

                picImage.Image = Image.FromFile(openFileDialog.FileName);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            string imageId = txtImageId.Text.Trim();

            if (ImageIdExists(imageId))
            {
                MessageBox.Show("This Image ID already exists. Please enter a different Image ID.",
                                "Duplicate Image ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtImageId.Focus();
                return;
            }

            string imageTitle = txtImageTitle.Text.Trim();
            string imagePath = txtImagePath.Text.Trim();
            string dateAdded = DateTime.Now.ToString();

            imageTable.Rows.Add(imageId, imageTitle, imagePath, dateAdded);

            MessageBox.Show("Image record added successfully.",
                            "Record Added",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            ClearInputFields();

        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void dgvImages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvImages.Rows[e.RowIndex];

            txtImageId.Text = row.Cells["Image ID"].Value.ToString();
            txtImageTitle.Text = row.Cells["Image Title"].Value.ToString();
            txtImagePath.Text = row.Cells["Image Path"].Value.ToString();

            string imagePath = txtImagePath.Text;

            if (File.Exists(imagePath))
            {
                picImage.Image = Image.FromFile(imagePath);
            }
            else
            {
                picImage.Image = null;

                MessageBox.Show("The image file cannot be found.",
                                "File Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvImages.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an image record to delete.",
                                "No Record Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected image record?",
                                                  "Confirm Delete",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int rowIndex = dgvImages.SelectedRows[0].Index;

                imageTable.Rows.RemoveAt(rowIndex);

                ClearInputFields();

                MessageBox.Show("Image record deleted successfully.",
                                "Record Deleted",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (imageTable.Rows.Count == 0)
            {
                MessageBox.Show("There are no image records to clear.",
                                "Empty List",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to clear all image records?",
                                                  "Confirm Clear All",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                imageTable.Rows.Clear();

                ClearInputFields();

                MessageBox.Show("All image records have been cleared.",
                                "Records Cleared",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to exit?";

            if (imageTable.Rows.Count > 0)
            {
                message = "You have image records that are not saved permanently.\n\nAre you sure you want to exit?";
            }

            DialogResult result = MessageBox.Show(message,
                                                  "Confirm Exit",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
