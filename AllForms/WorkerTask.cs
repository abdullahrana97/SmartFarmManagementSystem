using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using SmartFarmManagementSystem.AllClasses;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFarmManagementSystem.AllForms
{
    public partial class WorkerTask : Form
    {
        public WorkerTask()
        {
            InitializeComponent();
        }

        int selectedworkerid = -1;
        int selectedtaskid = -1;
        int selectedfieldid = -1;
        int selectedworkerid_task = -1;
        int selectedtasktypeid = -1;

        private void dgvworkers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvworkers.Rows[e.RowIndex];
                selectedworkerid = Convert.ToInt32(row.Cells["WorkerId"].Value);
                txtname.Text = row.Cells["WorkerName"].Value.ToString();
                txtphone.Text = row.Cells["Phone"].Value.ToString();
                cmbrole.SelectedItem = row.Cells["WorkerRole"].Value.ToString();
            }

        }

        public void loadworkers()
        {
            string query;

            if (LoginInfo.role.ToLower() == "admin")
                query = "SELECT * FROM vw_getfarmerworkers";
            else
                query = "SELECT * FROM vw_getfarmerworkers WHERE FarmerID = " + LoginInfo.userid;


            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@f", LoginInfo.userid);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvworkers.DataSource = dt;
                    dgvworkers.Columns["WorkerID"].Visible = false;
                    dgvworkers.Columns["FarmerID"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            loadworkers();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {


            if (selectedworkerid == -1)
            {
                WorkerBL worker = new WorkerBL(txtname.Text, txtphone.Text, cmbrole.SelectedItem.ToString());
                if (!worker.checkinputs())
                {
                    MessageBox.Show("Please fill all fields");
                    return;
                }
                if (worker.addworker())
                {
                    MessageBox.Show("Worker added successfully");
                    loadworkers();
                    LoadWorkerDropdown();
                    txtname.Clear();
                    txtphone.Clear();
                    cmbrole.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Failed to add worker");
                }
            }

            else
            {
                WorkerBL worker = new WorkerBL(txtname.Text, txtphone.Text, cmbrole.SelectedItem.ToString());
                if (!worker.checkinputs())
                {
                    MessageBox.Show("Please fill all fields");
                    return;
                }
                if (worker.updateworker(selectedworkerid))
                {
                    MessageBox.Show("Worker updated successfully");
                    loadworkers();
                    txtname.Clear();
                    txtphone.Clear();
                    cmbrole.SelectedIndex = -1;
                    selectedworkerid = -1;
                }
                else
                {
                    MessageBox.Show("Failed to update worker");
                }
            }


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtphone.Clear();
            cmbrole.SelectedIndex = -1;
            selectedworkerid = -1;
            txtname.Focus();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selectedworkerid != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this worker?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    WorkerBL worker = new WorkerBL(txtname.Text, txtphone.Text, cmbrole.SelectedItem.ToString());
                    if (worker.deleteworker(selectedworkerid))
                    {
                        MessageBox.Show("Worker deleted successfully");
                        loadworkers();
                        txtname.Clear();
                        txtphone.Clear();
                        cmbrole.SelectedIndex = -1;
                        selectedworkerid = -1;
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete worker");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a worker to delete");
            }
        }




        private void LoadWorkerRoles()
        {
            cmbrole.Items.Clear();
            cmbrole.Items.Add("Irrigator");
            cmbrole.Items.Add("Harvester");
            cmbrole.Items.Add("Plowman");
            cmbrole.Items.Add("Pest Controller");
            cmbrole.Items.Add("General Worker");
        }

        private void WorkerTask_Load(object sender, EventArgs e)
        {
            dtpenddate.Enabled = false;
            LoadFieldDropdown();
            LoadTasks();
           loadworkers();
            LoadWorkerDropdown();
            LoadTaskTypeDropdown();
            LoadStatusItems();
            LoadWorkerRoles();


        }


        private void LoadFieldDropdown()
        {

            string query;
            if (LoginInfo.role.ToLower() == "admin")
                query = @"SELECT field.FieldID, 
                          CONCAT(farm.Name, ' - ', field.Name) AS FieldName
                          FROM field JOIN farm ON field.FarmID = farm.FarmID";
            else
                query = @"SELECT field.FieldID, 
                          CONCAT(farm.Name, ' - ', field.Name) AS FieldName
                          FROM field JOIN farm ON field.FarmID = farm.FarmID
                          WHERE farm.FarmerID = " + LoginInfo.userid;

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {

                    MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    cmbfield.DisplayMember = "FieldName";
                    cmbfield.ValueMember = "FieldID";
                    cmbfield.DataSource = dt;
                    cmbfield.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void LoadWorkerDropdown()
        {

            string query;
            if (LoginInfo.role.ToLower() == "admin")
                query = "SELECT WorkerID, CONCAT(workerName, ' - ', WorkerRole) AS WorkerName FROM worker";
            else
                query = "SELECT WorkerID, CONCAT(workerName, ' - ', WorkerRole) AS WorkerName FROM worker WHERE FarmerID = " + LoginInfo.userid;

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {

                    MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    cmbworker.DisplayMember = "WorkerName";
                    cmbworker.ValueMember = "WorkerID";
                    cmbworker.DataSource = dt;
                    cmbworker.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void LoadTaskTypeDropdown()
        {

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {

                    MySqlDataAdapter adp = new MySqlDataAdapter(
                        "SELECT TaskTypeID, Name FROM tasktype", con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    cmbtasktype.DisplayMember = "Name";
                    cmbtasktype.ValueMember = "TaskTypeID";
                    cmbtasktype.DataSource = dt;
                    cmbtasktype.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadStatusItems()
        {
            cmbstatus.Items.Clear();
            cmbstatus.Items.Add("Pending");
            cmbstatus.Items.Add("InProgress");
            cmbstatus.Items.Add("Completed");
            cmbstatus.SelectedIndex = 0;
        }

        private void cmbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbstatus.Text == "Completed")
                dtpenddate.Enabled = true;
            else
            {
                dtpenddate.Enabled = false;
            }
        }

        private void CheckRoleMismatch(string workerRole, string taskType)
        {
            Dictionary<string, string> roleTaskMap = new Dictionary<string, string>
            {
                {"Irrigator", "Irrigation"},
                {"Harvester", "Harvesting"},
                {"Plowman", "Plowing"},
                {"Pest Controller", "Pest Control"}
            };

            if (roleTaskMap.ContainsKey(workerRole))
            {
                if (roleTaskMap[workerRole] != taskType)
                {
                    MessageBox.Show(
                        "Warning: " + workerRole + " is usually assigned " +
                        roleTaskMap[workerRole] + " tasks. Are you sure?",
                        "Role Mismatch Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void cmbworker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbworker.SelectedValue == null || cmbtasktype.SelectedValue == null) return;

            int workerid = Convert.ToInt32(cmbworker.SelectedValue);
            int tasktypeid = Convert.ToInt32(cmbtasktype.SelectedValue);

            string workerRole = TaskBL.getWorkerRole(workerid);
            string taskTypeName = TaskBL.getTaskTypeName(tasktypeid);

            CheckRoleMismatch(workerRole, taskTypeName);

        }

        private void cmbtasktype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbworker.SelectedValue == null || cmbtasktype.SelectedValue == null) return;

            int workerid = Convert.ToInt32(cmbworker.SelectedValue);
            int tasktypeid = Convert.ToInt32(cmbtasktype.SelectedValue);

            string workerRole = TaskBL.getWorkerRole(workerid);
            string taskTypeName = TaskBL.getTaskTypeName(tasktypeid);

            CheckRoleMismatch(workerRole, taskTypeName);
        }

        private void btnsaveupdate_Click(object sender, EventArgs e)
        {
            int fieldid = Convert.ToInt32(cmbfield.SelectedValue);
            int workerid = Convert.ToInt32(cmbworker.SelectedValue);
            int tasktypeid = Convert.ToInt32(cmbtasktype.SelectedValue);
            
            if (fieldid <= 0 || workerid <= 0 || tasktypeid <= 0)
            {
                MessageBox.Show("Please select field, worker and task type.");
                return;
            }

            if (cmbfield.SelectedValue == null ||
               cmbworker.SelectedValue == null ||
               cmbtasktype.SelectedValue == null)
            {
                MessageBox.Show("Please select field, worker and task type.");
                return;
            }


            string status = cmbstatus.Text;
            DateTime startdate = dtpstartdate.Value;
            DateTime? enddate = cmbstatus.Text == "Completed" ? dtpenddate.Value : (DateTime?)null;

            TaskBL task = new TaskBL(fieldid, workerid, tasktypeid, status, startdate, enddate);

            if (!task.checkinputs())
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (selectedtaskid == -1)
            {
                if (task.addTask())
                {
                    MessageBox.Show("Task added!");
                    ClearTaskFields();
                    LoadTasks();
                }
            }
            else
            {
                if (task.updateTask(selectedtaskid))
                {
                    MessageBox.Show("Task updated!");
                    ClearTaskFields();
                    LoadTasks();
                }
            }
        }

        private void ClearTaskFields()
        {
            selectedtaskid = -1;
            cmbfield.SelectedIndex = -1;
            cmbworker.SelectedIndex = -1;
            cmbtasktype.SelectedIndex = -1;
            cmbstatus.SelectedIndex = 0;
            dtpstartdate.Value = DateTime.Now;
            dtpenddate.Enabled = false;
        }

        private void LoadTasks()
        {
            TaskBL task = new TaskBL(0, 0, 0, "", DateTime.Now, null);
            DataTable dt = task.loadTasks();
            if (dt != null)
            {
                dgvtasks.DataSource = dt;
                dgvtasks.Columns["TaskID"].Visible = false;
                dgvtasks.Columns["FieldID"].Visible = false;
                dgvtasks.Columns["WorkerID"].Visible = false;
                dgvtasks.Columns["TaskTypeID"].Visible = false;
                dgvtasks.Columns["FarmerID"].Visible = false;
            }
        }

        private void buttdelete_Click(object sender, EventArgs e)
        {
            if (selectedtaskid == -1)
            {
                MessageBox.Show("Please select a task first.");
                return;
            }

            if (MessageBox.Show("Delete this task?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TaskBL task = new TaskBL(0, 0, 0, "", DateTime.Now, null);
                if (task.deleteTask(selectedtaskid))
                {
                    MessageBox.Show("Deleted.");
                    ClearTaskFields();
                    LoadTasks();
                }
            }
        }

        private void dgvtasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvtasks.Rows[e.RowIndex];

                selectedtaskid = Convert.ToInt32(row.Cells["TaskID"].Value);

                selectedfieldid = Convert.ToInt32(row.Cells["FieldID"].Value);
                selectedworkerid_task = Convert.ToInt32(row.Cells["WorkerID"].Value);
                selectedtasktypeid = Convert.ToInt32(row.Cells["TaskTypeID"].Value);

                SetComboValue(cmbfield, "FieldID",
                    Convert.ToInt32(row.Cells["FieldID"].Value));

                SetComboValue(cmbworker, "WorkerID",
                    Convert.ToInt32(row.Cells["WorkerID"].Value));

                SetComboValue(cmbtasktype, "TaskTypeID",
                    Convert.ToInt32(row.Cells["TaskTypeID"].Value));

                cmbstatus.Text = row.Cells["Status"].Value.ToString();

                dtpstartdate.Value =
                    Convert.ToDateTime(row.Cells["StartDate"].Value);

                if (row.Cells["EndDate"].Value != DBNull.Value &&
                    row.Cells["EndDate"].Value != null)
                {
                    dtpenddate.Enabled = true;
                    dtpenddate.Value =
                        Convert.ToDateTime(row.Cells["EndDate"].Value);
                }
                else
                {
                    dtpenddate.Enabled = false;
                }
            }
        }


        private void SetComboValue(ComboBox cmb, string valueMember, int id)
        {
            foreach (DataRowView row in cmb.Items)
            {
                if (Convert.ToInt32(row[valueMember]) == id)
                {
                    cmb.SelectedItem = row;
                    return;
                }
            }
        }

        private void buttclear_Click(object sender, EventArgs e)
        {
          
        
            selectedtaskid = -1;
            selectedfieldid = -1;
            selectedworkerid_task = -1;
            selectedtasktypeid = -1;


            cmbfield.SelectedIndex = -1;
            cmbworker.SelectedIndex = -1;
            cmbtasktype.SelectedIndex = -1;
            cmbstatus.SelectedIndex = 0;
            dtpstartdate.Value = DateTime.Now;
            dtpenddate.Enabled = false;
     
        
        }


    }
    }
    

