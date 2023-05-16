using Microsoft.Data.SqlClient;

using System.Configuration;
using System.Data;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString))
            {
                sqlConnection.Open();
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand getAllTouristsInfo = sqlConnection.CreateCommand();
                    getAllTouristsInfo.CommandText = "SELECT * FROM Tourists JOIN TouristsInfo ON Tourists.ID = TouristsInfo.TouristID";
                    DataTable touristsInfo = GetData(getAllTouristsInfo);
                    touristsInfo.Columns.Remove("TouristID");
                    TouristsView.AutoGenerateColumns = true;
                    TouristsView.DataSource = touristsInfo;
                    TouristsView.Columns[0].Width = 25;

                    SqlCommand getTours = sqlConnection.CreateCommand();
                    getTours.CommandText = "SELECT * FROM Tours";
                    DataTable tours = GetData(getTours);
                    ToursView.AutoGenerateColumns = true;
                    ToursView.DataSource = tours;
                    ToursView.Columns[0].Width = 50;
                    ToursView.Columns[3].Width = 500;

                    SqlCommand getSeasons = sqlConnection.CreateCommand();
                    getSeasons.CommandText = "SELECT Seasons.SeasonID, Seasons.StartDate, Seasons.EndDate, Seasons.SeatsCount, Seasons.IsSeasonClosed, Tours.Name, Tours.Price, Tours.Info FROM Tours JOIN Seasons ON Tours.TourID = Seasons.TourID";
                    DataTable seasons = GetData(getSeasons);
                    SeasonsView.AutoGenerateColumns = true;
                    SeasonsView.DataSource = seasons;
                    SeasonsView.Columns[0].Width = 75;

                    SqlCommand getTravels = sqlConnection.CreateCommand();
                    getTravels.CommandText = "SELECT Tourists.Surname, Tourists.Name, Seasons.SeasonID FROM Travels JOIN Tourists ON Travels.TouristID = Tourists.ID JOIN Seasons ON Travels.SeasonID = Seasons.SeasonID";
                    DataTable travels = GetData(getTravels);
                    travels.Columns[0].ColumnName = "Surname";
                    travels.Columns[1].ColumnName = "Tourist Name";
                    SqlCommand getSeasonsTravels = sqlConnection.CreateCommand();
                    getSeasonsTravels.CommandText = "SELECT Seasons.SeasonID, Tours.Name, Tours.Price, Tours.Info FROM Seasons JOIN Tours ON Seasons.TourID = Tours.TourID";
                    travels = FullOuterJoinDataTables(travels, GetData(getSeasonsTravels));
                    travels.Columns[3].ColumnName = "Tour Name";
                    TravelsView.AutoGenerateColumns = true;
                    TravelsView.DataSource = travels;

                    SqlCommand getPayments = sqlConnection.CreateCommand();
                    getPayments.CommandText = "SELECT Payments.Cost, Travels.ID FROM Payments JOIN Travels ON Payments.TravelID = Travels.ID" ;
                    DataTable payments = GetData(getPayments);
                    SqlCommand getTouristPayment = sqlConnection.CreateCommand();
                    getTouristPayment.CommandText = "SELECT Travels.ID, Tourists.Name, Tourists.Surname FROM Travels JOIN Tourists ON Travels.TouristID = Tourists.ID";
                    payments = FullOuterJoinDataTables(GetData(getTouristPayment), payments);
                    payments.Columns["ID"].ColumnName = "TravelID";
                    PaymentsView.AutoGenerateColumns = true;
                    PaymentsView.DataSource = payments;
                }
            }
        }

        private DataTable GetData(SqlCommand command)
        {
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
            {
                DataTable ds = new DataTable();
                dataAdapter.Fill(ds);
                return ds;
            }
        }

        private DataTable FullOuterJoinDataTables(params DataTable[] datatables) // supports as many datatables as you need.
        {
            DataTable result = datatables.First().Clone();

            var commonColumns = result.Columns.OfType<DataColumn>();

            foreach (var dt in datatables.Skip(1))
            {
                commonColumns = commonColumns.Intersect(dt.Columns.OfType<DataColumn>(), new DataColumnComparer());
            }

            result.PrimaryKey = commonColumns.ToArray();

            foreach (var dt in datatables)
            {
                result.Merge(dt, false, MissingSchemaAction.AddWithKey);
            }

            return result;
        }

        /* also create this class */
        public class DataColumnComparer : IEqualityComparer<DataColumn>
        {
            public bool Equals(DataColumn x, DataColumn y) { return x.Caption == y.Caption; }

            public int GetHashCode(DataColumn obj) { return obj.Caption.GetHashCode(); }

        }
    }
}