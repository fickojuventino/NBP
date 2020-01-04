using EasyInsurance.Models;
using Neo4j.Driver.V1;
using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyInsurance
{
    public partial class EasyInsurance : Form
    {
        public EasyInsurance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraphClient client;
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "graph");
            try
            {
                client.Connect();

                User korisnik = new User
                {
                    Name = "Mustafa",
                    From = "MUSTAFIC",
                    Klout = "91"
                };

                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("name", korisnik.Name);
                queryDict.Add("from", korisnik.From);
                queryDict.Add("klout", korisnik.Klout);

                var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Person {Name:'" + korisnik.Name + "', From:'" + korisnik.From
                                                                + "', Klout:'" + korisnik.Klout
                                                                + "'}) return n",
                                                                queryDict, CypherResultMode.Set);
                List<User> users = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).ToList();

                //var query = new Neo4jClient.Cypher.CypherQuery("MATCH (a:Person) WHERE a.name <> 'Ian' RETURN a",
                //                               new Dictionary<string, object>(), CypherResultMode.Set);

                //List<User> users = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).ToList();

                foreach (User u in users)
                {
                    MessageBox.Show(u.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //using (var driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "graph")))
            //using (var session = driver.Session())
            //{
            //    //session.Run("CREATE (a:Person {name:'Arthur', title:'King'})");
            //    //var result = session.Run("MATCH (a:Person) WHERE a.name = 'Ian' RETURN a");

            //    var result = session.Run("match (n)-[r:FRIEND]->(friend) return friend", new Dictionary<string, object>());

            //    //foreach (User record in result)
            //    //    MessageBox.Show($"{record.Name.As<string>()} {record.From.As<string>()}");

            //    List<User> users = ((IRawGraphClient)driver).ExecuteGetCypherResults<User>(result).ToList();
            //}

            //var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:FRIEND]->(friend) return friend",
            //                                               new Dictionary<string, object>(), CypherResultMode.Set);

            //List<User> users = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).ToList();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
