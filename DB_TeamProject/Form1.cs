using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_TeamProject
{
    enum SearchKeyword
    {

    }

    public partial class Form1 : Form
    {
        private DBManager dm = DBManager.getInstance(); // 싱글톤으로 DBManager 인스턴스 생성 (DB 접속 관리)
        DataTable mainDataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void departmentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentDepartmentId = departmentBox.SelectedIndex.ToString(); // 부서 목록에서 현재 선택한 부서 index 받아옴
            string getDepartmentInfoQuery = $"SELECT * FROM department WHERE 부서id = {currentDepartmentId}"; // 인덱스번호로 부서 id 조회하는 쿼리
            mainDataTable = dm.RunQueryWithReader(getDepartmentInfoQuery);
            dataGridView1.DataSource = mainDataTable;

            DataTable teamInfoTable = new DataTable();

            string getTeamInfoQuery = $"SELECT distinct 팀명 FROM department WHERE 부서id = {currentDepartmentId} order by 팀명";
            teamInfoTable = dm.RunQueryWithReader(getTeamInfoQuery);

            teamBox.Items.Clear(); // 부서명을 조회할때 마다 바뀌므로 초기화

            foreach (DataRow row in teamInfoTable.Rows) // 쿼리 결과로 받아온 팀명을 하나씩 teamBox에 넣어줌
            {
                teamBox.Items.Add(row["팀명"]);
            }
        }

        private void teamBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentTeamName = teamBox.SelectedItem.ToString();
            string getTeamInfoQuery = $"SELECT * FROM department WHERE 팀명 = '{currentTeamName}' order by 유저id";
            mainDataTable = dm.RunQueryWithReader(getTeamInfoQuery);
            dataGridView1.DataSource = mainDataTable;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string msg = String.Format(
                "Cell at row {0}, column {1} value changed",
                e.RowIndex, e.ColumnIndex);
            MessageBox.Show(msg, "Cell Value Changed");
        }

        private void addDepartmentBtnClick(object sender, EventArgs e)
        {
            addDepartmentPanel.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addDepartmentPanel.Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
