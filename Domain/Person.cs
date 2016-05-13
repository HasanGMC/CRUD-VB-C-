// Generation Multinet Computindo
// Copyright (c) 2014 GMComputindo - HasanGMC.

// managing Access Data (CRUD).

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
using System.Linq;

namespace Domain
{
    public class Person
    {
        int ID;
        public int id
        {
            get { return ID; }
            set { ID = value; } 
        }
        string nama;
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }
        string PHONE;
        public string phone
        {
            get { return PHONE; }
            set { PHONE = value; }
        }

        public override string ToString()
        {
            return Nama + " " + phone;
        }
   }
}
