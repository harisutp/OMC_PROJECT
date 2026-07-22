using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace OMC_PROJECT
{
    public partial class formadmin : Form
    {
        private static readonly string connString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            + AppDomain.CurrentDomain.BaseDirectory + "OMC.accdb";

        // Describes one database table: its real name (with brackets ready
        // for SQL), the ID column used to search it, and the columns to
        // display, in the order they should fill lblCap1/lblVal1 onward.
        private class TableInfo
        {
            public string TableName;
            public string IdColumn;
            public string[] Columns;
        }

        private readonly Dictionary<string, TableInfo> tables = new Dictionary<string, TableInfo>
        {
            ["Customer"] = new TableInfo
            {
                TableName = "[customer Sign in]",
                IdColumn = "CustomerID",
                Columns = new[] { "CustomerID", "Customer Name", "Email", "Password", "Customer Number", "Disabilities" }
            },
            ["Driver"] = new TableInfo
            {
                TableName = "[Driver sign in]",
                IdColumn = "DriverID",
                Columns = new[] { "DriverID", "DriverName", "CarType", "Phone number", "Email", "Password" }
            },
            ["Order"] = new TableInfo
            {
                TableName = "[Order]",
                IdColumn = "OrderID",
                Columns = new[] { "OrderID", "CustomerID", "Price", "Pick up", "Destination", "DriverID" }
            },
            ["Receipt"] = new TableInfo
            {
                TableName = "[Receipt]",
                IdColumn = "ReceiptID",
                Columns = new[] { "ReceiptID", "OrderID", "Prices", "Payment Method", "Payment Status", "RideID" }
            },
            ["Ride"] = new TableInfo
            {
                TableName = "[Ride]",
                IdColumn = "RideID",
                Columns = new[] { "RideID", "DriverID", "OrderID" }
            }
        };

        // The caption/value label pairs, in order, so they can be filled
        // or cleared in a loop instead of one by one.
        private Label[] captionLabels;
        private Label[] valueLabels;

        public formadmin()
        {
            InitializeComponent();

            captionLabels = new[] { lblCap1, lblCap2, lblCap3, lblCap4, lblCap5, lblCap6 };
            valueLabels = new[] { lblVal1, lblVal2, lblVal3, lblVal4, lblVal5, lblVal6 };
        }

        private void formadmin_Load(object sender, EventArgs e)
        {
            cboTable.Items.Clear();
            foreach (string tableKey in tables.Keys)
            {
                cboTable.Items.Add(tableKey);
            }
            cboTable.SelectedIndex = 0;

            ClearLabels();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboTable.SelectedItem == null)
            {
                MessageBox.Show("Please choose a table.", "Missing selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idText = txtSearchId.Text.Trim();
            if (string.IsNullOrWhiteSpace(idText) || !int.TryParse(idText, out int searchId))
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Missing ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tableKey = cboTable.SelectedItem.ToString();
            TableInfo info = tables[tableKey];

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    string sql = $"SELECT * FROM {info.TableName} WHERE [{info.IdColumn}] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", searchId);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                FillLabels(reader, info.Columns);
                            }
                            else
                            {
                                ClearLabels();
                                MessageBox.Show("No record found with that ID.", "Not found",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load the record.\n\n" + ex.Message,
                    "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fills as many caption/value pairs as the table has columns,
        // and blanks out any pairs left over (e.g. Ride only uses 3 of 6).
        private void FillLabels(OleDbDataReader reader, string[] columns)
        {
            for (int i = 0; i < captionLabels.Length; i++)
            {
                if (i < columns.Length)
                {
                    object value = reader[columns[i]];
                    captionLabels[i].Text = columns[i];
                    valueLabels[i].Text = (value == DBNull.Value) ? "-" : value.ToString();
                }
                else
                {
                    captionLabels[i].Text = "";
                    valueLabels[i].Text = "";
                }
            }
        }

        private void ClearLabels()
        {
            foreach (Label lbl in captionLabels) lbl.Text = "";
            foreach (Label lbl in valueLabels) lbl.Text = "";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?",
                "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Session.CurrentUser = null;

                // Closing this form closes the whole navigation chain,
                // which brings the user back to the login form.
                this.Close();

                
            }
        }
    }
}
