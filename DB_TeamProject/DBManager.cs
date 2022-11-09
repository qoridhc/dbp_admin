using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_TeamProject
{
    class DBManager
    {
        private static DBManager dbInstance = new DBManager(); // 싱긅톤 객체로 DBManager 생성

        private string connStr = "Data Source=127.0.0.1; Database=db_teamproject; Uid=root;Pwd=1234;CharSet=utf8"; // 서버 접속을 위한 connStr

        private DBManager() // 싱글톤 객체이므로 외부에서 생성자로 생성 못하게 막아둠
        {
        }

        public static DBManager getInstance() // DBManager 인스턴스 반환
        {
            return dbInstance;
        }
        public MySqlConnection getConnection()  // Connection 생성해서 반환
        {
            return new MySqlConnection(connStr);
        }

        public DataTable RunQueryWithReader(string query) // select를 실행하는 쿼리
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = getConnection())
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection); // 전공 테이블을 받아서
                MySqlDataReader newReader = cmd.ExecuteReader();
                dt.Load(newReader);
            }

            return dt;
        }

        public void RunNoneQuery(string query) // Insert, Delete, Update를 실행해주는 함수
        {
            using (MySqlConnection connection = getConnection())
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection); // 쿼리 실행
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }


    }
}
