using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonDB
{
    public partial class Form1 : Form
    {
        List<Player> allPlayers = new List<Player>();
        List<Pokemon> allPokemon = new List<Pokemon>();
        List<Ownership> allOwnership = new List<Ownership>();
        public Form1()
        {
            InitializeComponent();
            LoadPlayerData();
            LoadPokemonData();
            LoadOwnershipData();
            PopulateCityCombo();
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string city = cityComboBox.SelectedItem.ToString();

            var Players = from p in allPlayers
                          where p.Hometown == city
                          where p.Paid == true
                          select p;
            var Players2 = from p in allPlayers
                           where p.Hometown == city
                           where p.Paid == false
                           select p;
            cityGridView.AutoGenerateColumns = true;
            cityGridView.DataSource = new BindingSource(Players, null);
            UnpaidGridView.AutoGenerateColumns = true;
            UnpaidGridView.DataSource = new BindingSource(Players2, null);
        }
        void LoadPlayerData()
        {
            string[] lines = Properties.Resources.Players.Trim().Split('\n');

            //loop through lines
            foreach (string line in lines)
            {
                //split into fields
                string[] fields = line.Trim().Split(',');

                Player p = new Player //make  a Player obj
                {
                    Name = fields[0],
                    ID = Convert.ToInt32(fields[1]),
                    Nickname = fields[2],
                    Hometown = fields[3],
                    Paid = Convert.ToBoolean(fields[4])
                };

                allPlayers.Add(p); //save it
            }//end foreach

            //populate grid view
            cityGridView.AutoGenerateColumns = true;
            cityGridView.DataSource = allPlayers;
        }//end load data
        void LoadPokemonData()
        {
            string[] lines = Properties.Resources.Pokemon.Trim().Split('\n');

            //loop through lines
            foreach (string line in lines)
            {
                //split into fields
                string[] fields = line.Trim().Split(',');

                Pokemon p = new Pokemon 
                {
                    ID = Convert.ToInt32(fields[0]),
                    Name = fields[1],
                    Attack = Convert.ToInt32(fields[2]),
                    Defense = Convert.ToInt32(fields[3])
                };

                allPokemon.Add(p); //save it
            }//end foreach

            //populate grid view
            AttackGridView1.AutoGenerateColumns = true;
            AttackGridView1.DataSource = allPokemon;
        }//end load data

        void LoadOwnershipData()
        {
            string[] lines = Properties.Resources.Ownership.Trim().Split('\n');

            //loop through lines
            foreach (string line in lines)
            {
                //split into fields
                string[] fields = line.Trim().Split(',');

                Ownership o = new Ownership 
                {
                    PlayerID = Convert.ToInt32(fields[0]),
                    PokemonID = Convert.ToInt32(fields[1]),
                    Level = Convert.ToInt32(fields[2]),
                    numOwned = Convert.ToInt32(fields[3])
                };

                allOwnership.Add(o); //save it
            }//end foreach

            //populate grid view
            OwneshipGridView1.AutoGenerateColumns = true;
            OwneshipGridView1.DataSource = allOwnership;
        }//end load data
        void PopulateCityCombo()
        {
            var cities = from p in allPlayers select p.Hometown;
            //removed duplicates
            HashSet<string> set = new HashSet<string>(cities);

            cityComboBox.Items.AddRange(set.ToArray());
        }

        private void AttackButton_Click(object sender, EventArgs e)
        {
            
            int attack = Convert.ToInt32(AttacktextBox.Text);

            var attacks = from p in allPokemon
                          where p.Attack >= attack
                          orderby p.Attack descending
                          select new { p.Name, p.ID, p.Attack, p.Defense };

            AttackGridView1.AutoGenerateColumns = true;
            AttackGridView1.DataSource = new BindingSource(attacks, null);
        }

        private void DefenseButton_Click(object sender, EventArgs e)
        {
            int defense = Convert.ToInt32(DefenseTextBox.Text);

            var defenses = from p in allPokemon
                          where p.Defense >= defense
                           orderby p.Defense descending
                           select new { p.Name, p.ID, p.Attack, p.Defense };
            defenses.OrderByDescending(o => o.Defense);
            AttackGridView1.AutoGenerateColumns = true;
            AttackGridView1.DataSource = new BindingSource(defenses, null);

        }
      
        private void NicknameSubmit_Click(object sender, EventArgs e)
        {
            string nick = PlayerNickTextbox.Text;

            var TrainerPokemon = from p in allPlayers
                                 where p.Nickname == nick
                                 join o in allOwnership on p.ID equals o.PlayerID
                                 join pmon in allPokemon on o.PokemonID equals pmon.ID
                                 select new { pmon.Name, o.Level, o.numOwned };

            OwneshipGridView1.AutoGenerateColumns = true;
            OwneshipGridView1.DataSource = new BindingSource(TrainerPokemon, null);
        }
    }
}
