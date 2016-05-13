// Generation Multinet Computindo
// Copyright (c) 2014 GMComputindo - HasanGMC.

// managing SQL Data (CRUD).

// For more information on partnerships,
// please visit http://www.gmcomputindo.com/

// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, 
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
// IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
// INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES 
// (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; 
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
// WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
// ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Session
{
    public class Broker
    {
        OleDbConnection connection;
        OleDbCommand command;

        private void connectTo()
        {
            connection = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project_C#\CRUD\Database.accdb;Persist Security Info=False");
            command = connection.CreateCommand();
        }

        public Broker()
        {
            connectTo();
        }

        public void simpan(Person p)
        {
            try
            {
                command.CommandText = "INSERT INTO TPersons (Nama,phone) VALUES('"+p.Nama+"', '"+p.phone+"')";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public List<Person> FillComboBox()
        {
            List<Person> PersonsList = new List<Person>();
            try
            {
                command.CommandText = "SELECT * FROM TPersons";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Person p = new Person();
                    p.id = Convert.ToInt32(reader["id"].ToString());
                    p.Nama = reader["Nama"].ToString();
                    p.phone = reader["phone"].ToString();

                    PersonsList.Add(p);
                }
                return PersonsList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    
                    connection.Close();
                }
            }
        }

        public void update(Person OldPerson, Person NewPerson)
        {
            try
            {
                command.CommandText = "UPDATE TPersons SET Nama='" + NewPerson.Nama  + "', phone ='" + NewPerson.phone + "' where id = " + OldPerson.id;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void Delete(Person p)
        {
            try
            {
                command.CommandText = "DELETE FROM TPersons WHERE id = " + p.id;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
 }
