// Generation Multinet Computindo
// Copyright (c) 2014 GMComputindo - HasanGMC.

// managing Data Access (CRUD).

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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Session;

namespace Crud
{
    public partial class Form1 : Form
    {
        Broker b = new Broker();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Nama = textBox1.Text;
            p.phone = textBox2.Text;

            b.simpan(p);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.DataSource = b.FillComboBox();  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Person OldPerson = new Person();
            Person NewPerson = new Person();
            OldPerson = comboBox1.SelectedItem as Person;
            NewPerson.Nama = textBox3.Text;
            NewPerson.phone = textBox4.Text;
            b.update(OldPerson,NewPerson);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p = comboBox1.SelectedItem as Person;
            b.Delete(p);
        }
    }
}
