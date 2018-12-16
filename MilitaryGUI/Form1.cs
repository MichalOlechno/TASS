using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using tass___military;
using tass___military.DataProvider;
using tass___military.Models;

namespace MilitaryGUI
{
    public partial class Form1 : Form
    {
        private List<military_full> allies;
        public Form1()
        {
            InitializeComponent();
            var countries = DataProvider.GetAllCountries();
            foreach (var country in countries)
            {
                CountriesNames.Items.Add(country.Country);
            }
            FillData(PickData);
            allies = new List<military_full>();
            
            ChartPanel.Visible = false;
            MainPanel.Visible = true;
        }

        private void GetAllies_Click(object sender, EventArgs e)
        {
            var selectedItem = CountriesNames.SelectedItem;
            if (selectedItem != null)
                dataGridView1.DataSource = FillTable(selectedItem.ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ChartPanel.Visible = false;
        }

        private void DrawChart_Click(object sender, EventArgs e)
        {
            Chart1.Series.Clear();
            double max = 0;
            var property = PickData.SelectedItem.ToString();
            Chart1.Series.Add(property);
            
            DataPoint dp = new DataPoint();
            var country = DataProvider.GetCountry(CountriesNames.SelectedItem.ToString());
            double value = GetProperty(country, property);
            dp.SetValueXY(country.Country, value);
            Chart1.Series[property].Points.Add(dp);
            foreach (var ally in allies)
            {
                if (ally != null)
                {
                    dp = new DataPoint();
                    value = GetProperty(ally, property);
                    dp.SetValueXY(ally.Country,value);
                    Chart1.Series[property].Points.Add(dp);
                    if (max < value)
                        max = value;
                }
            }
            Chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.NotSet;
            Chart1.Series[0].IsValueShownAsLabel = true;
            Chart1.Series[0].SmartLabelStyle.IsMarkerOverlappingAllowed = false;
            Chart1.Series[0].SmartLabelStyle.MaxMovingDistance = 10;

            Chart1.ChartAreas[0].AxisY.Maximum = 1.1*max;
            Chart1.ChartAreas[0].AxisX.Interval = 1;
            ChartPanel.Visible = true;
        }
        private double GetProperty(military_full ally, String property)
        {
            double result;
            switch (property)
            {
                case "Military_budget__US__BN": { result = ally.Military_budget__US__BN_; } break;
                case "Main_battle_tanks": { result = ally.Main_battle_tanks; } break;
                case "Aircraft_carriers": { result = ally.Aircraft_carriers; } break;
                case "AWS": { result = ally.AWS; } break;
                case "Cruisers": { result = ally.Cruisers; } break;
                case "Destroyers": { result = ally.Destroyers; } break;
                case "Frigates": { result = ally.Frigates; } break;
                case "Corvettes": { result = ally.Corvettes; } break;
                case "Nuclear_submarines": { result = ally.Nuclear_submarines; } break;
                case "Non_nuclear_Submarines": { result = ally.Non_nuclear_Submarines; } break;
                case "Military_aircraft": { result = ally.Military_aircraft; } break;
                case "Attack_helicopters": { result = ally.Attack_helicopters; } break;
                case "Nuclear_weapons": { result = ally.Nuclear_weapons; } break;
                case "Military_satellites": { result = ally.Military_satellites; } break;
                case "Active_military": { result = ally.Active_military; } break;
                case "Reserve_military": { result = ally.Reserve_military; } break;
                case "Paramilitary": { result = ally.Paramilitary; } break;
                case "Total_military": { result = ally.Total; } break;
                case "Per_1000_capita_total_military": { result = ally.Per_1000_capita_total_; } break;
                case "Per_1000_capita_active_military": { result = ally.Per_1000_capita_active_; } break;
                default: result = -1; break;

            }
            return result;
        }


        private DataTable FillTable(string CountryName)
        {
            DataTable table = new DataTable();
            SetColumns(table);
            var country = DataProvider.GetCountry(CountryName);
            table.Rows.Add(GetDataRow(table, country));
            allies.Clear();
            allies = DataProvider.GetAlliesData(CountryName);
            foreach (var ally in allies)
            {
                if (ally != null)
                {
                    table.Rows.Add(GetDataRow(table, ally));
                }
            }

            return table;
        }




        private void FillData(ListBox pickData)
        {
            pickData.Items.Add("Military_budget__US__BN");
            pickData.Items.Add("Main_battle_tanks");
            pickData.Items.Add("Aircraft_carriers");
            pickData.Items.Add("AWS");
            pickData.Items.Add("Cruisers");
            pickData.Items.Add("Destroyers");
            pickData.Items.Add("Frigates");
            pickData.Items.Add("Corvettes");
            pickData.Items.Add("Nuclear_submarines");
            pickData.Items.Add("Non_nuclear_Submarines");
            pickData.Items.Add("Military_aircraft");
            pickData.Items.Add("Attack_helicopters");
            pickData.Items.Add("Nuclear_weapons");
            pickData.Items.Add("Military_satellites");
            pickData.Items.Add("Active_military");
            pickData.Items.Add("Reserve_military");
            pickData.Items.Add("Paramilitary");
            pickData.Items.Add("Total_military");
            pickData.Items.Add("Per_1000_capita_total_military");
            pickData.Items.Add("Per_1000_capita_active_military");
        }

        private DataRow GetDataRow(DataTable table, military_full countryData)
        {
            DataRow dr = table.NewRow();
            dr["Name"] = countryData.Country;
            dr["Military_budget__US__BN"] = countryData.Military_budget__US__BN_;
            dr["Main_battle_tanks"] = countryData.Main_battle_tanks;
            dr["Aircraft_carriers"] = countryData.Aircraft_carriers;
            dr["AWS"] = countryData.AWS;
            dr["Cruisers"] = countryData.Cruisers;
            dr["Destroyers"] = countryData.Destroyers;
            dr["Frigates"] = countryData.Frigates;
            dr["Corvettes"] = countryData.Corvettes;
            dr["Nuclear_submarines"] = countryData.Nuclear_submarines;
            dr["Non_nuclear_Submarines"] = countryData.Non_nuclear_Submarines;
            dr["Military_aircraft"] = countryData.Military_aircraft;
            dr["Attack_helicopters"] = countryData.Attack_helicopters;
            dr["Nuclear_weapons"] = countryData.Nuclear_weapons;
            dr["Military_satellites"] = countryData.Military_satellites;
            dr["Active_military"] = countryData.Active_military;
            dr["Reserve_military"] = countryData.Reserve_military;
            dr["Paramilitary"] = countryData.Paramilitary;
            dr["Total_military"] = countryData.Total;
            dr["Per_1000_capita_total_military"] = countryData.Per_1000_capita_total_;
            dr["Per_1000_capita_active_military"] = countryData.Per_1000_capita_active_;
            return dr;

        }
        private void SetColumns(DataTable table)
        {
            table.Columns.Add("Name".ToString());
            table.Columns.Add("Military_budget__US__BN".ToString());
            table.Columns.Add("Main_battle_tanks".ToString());
            table.Columns.Add("Aircraft_carriers".ToString());
            table.Columns.Add("AWS".ToString());
            table.Columns.Add("Cruisers".ToString());
            table.Columns.Add("Destroyers".ToString());
            table.Columns.Add("Frigates".ToString());
            table.Columns.Add("Corvettes".ToString());
            table.Columns.Add("Nuclear_submarines".ToString());
            table.Columns.Add("Non_nuclear_Submarines".ToString());
            table.Columns.Add("Military_aircraft".ToString());
            table.Columns.Add("Attack_helicopters".ToString());
            table.Columns.Add("Nuclear_weapons".ToString());
            table.Columns.Add("Military_satellites".ToString());
            table.Columns.Add("Active_military".ToString());
            table.Columns.Add("Reserve_military".ToString());
            table.Columns.Add("Paramilitary".ToString());
            table.Columns.Add("Total_military".ToString());
            table.Columns.Add("Per_1000_capita_total_military".ToString());
            table.Columns.Add("Per_1000_capita_active_military".ToString());
        }
    }

}
