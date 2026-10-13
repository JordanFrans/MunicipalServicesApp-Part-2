using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class ReportIssueForm : Form
    {
        private List<Issue> issues = new List<Issue>();
        private string attachmentPath = "";

        public ReportIssueForm()
        {
            InitializeComponent();

            cmbCategory.Items.Add("Water");
            cmbCategory.Items.Add("Electricity");
            cmbCategory.Items.Add("Roads");
            cmbCategory.Items.Add("Sanitation");
            cmbCategory.Items.Add("Waste");
            cmbCategory.Items.Add("Streetlights");
            cmbCategory.Items.Add("Other");

            cmbCategory.SelectedIndex = 0;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            lblProgress.Text = "Report completion: 0%";
            lblAttachment.Text = "No file selected";
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter =
                "Images and Documents|*.jpg;*.jpeg;*.png;*.pdf;*.docx;*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                attachmentPath = openFileDialog.FileName;
                lblAttachment.Text = Path.GetFileName(attachmentPath);

                UpdateProgress();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show(
                    "Please enter the location of the issue.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtLocation.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show(
                    "Please provide a description of the issue.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                rtbDescription.Focus();
                return;
            }

            Issue newIssue = new Issue
            {
                Location = txtLocation.Text,
                Category = cmbCategory.SelectedItem.ToString(),
                Description = rtbDescription.Text,
                AttachmentPath = attachmentPath,
                DateReported = DateTime.Now,
                Status = "Submitted"
            };

            issues.Add(newIssue);

            progressBar1.Value = 100;
            lblProgress.Text = "Report completion: 100%";

            MessageBox.Show(
                "Your issue has been successfully reported!\n\nThank you for helping improve your community.",
                "Report Submitted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void UpdateProgress()
        {
            int progress = 0;

            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                progress += 25;
            }

            if (cmbCategory.SelectedIndex >= 0)
            {
                progress += 25;
            }

            if (!string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                progress += 25;
            }

            if (!string.IsNullOrWhiteSpace(attachmentPath))
            {
                progress += 25;
            }

            progressBar1.Value = progress;
            lblProgress.Text = "Report completion: " + progress + "%";
        }

        private void ClearForm()
        {
            txtLocation.Clear();
            cmbCategory.SelectedIndex = 0;
            rtbDescription.Clear();

            attachmentPath = "";
            lblAttachment.Text = "No file selected";

            progressBar1.Value = 0;
            lblProgress.Text = "Report completion: 0%";
        }
    }
}
