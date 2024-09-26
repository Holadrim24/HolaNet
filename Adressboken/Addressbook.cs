using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.Drawing;
using System;
using System.Reflection.PortableExecutable;

namespace Adressboken
{

//Uppgiften handlar om att skapa en adressbok. All information skall sparas i en textfil.
//Det betyder att applikationen skall kunna läsa och skriva från denna textfil. Gränssnittet till
//applikationen skall skapas i Windows Forms. Krav för att uppgiften skall bli godkänd:
//
//1. Följande information skall kunna registreras och sparas till textfilen, namn, gatudress,
//postnummer, postort, telefon och epost
//
//2. Det skall gå att spara en ny adress i adressboken men också uppdatera en adress som
//   redan finns.
//
//3. Det skall gå att ta bort en adress och den skall då försvinna från adressboken.
//
//4. Det skall gå att söka på en eller flera adresser och sökresultatet skall visas i en lista.
//   Från listan skall det gå att klicka på en rad och få upp all information om den adressen.
//
//5. Sökningen skall fungera som ett urval där det minst skall gå att göra urval på namn
//   och postort.
//
//Koden skall fungera och applikationen skall gå att köra utan fel
    public partial class Addressbook : Form
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int PostalNumber { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Addressbook() //Konstruktorn
        {
            InitializeComponent();
        }

        //Sparar information till textfilen
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text; 
            string address = txtAddress.Text;
            int postalNumber = int.Parse(txtPostalNo.Text);
            string city = txtCity.Text;
            string phone = txtPhoneNumber.Text;
            string email = txtEmail.Text;   

            //Skapar en sökväg till filen på hårddisken
            string filePath = @"C:\Addressbook\adressbook.txt";
            //Skapar en StreamWriter som pekar på filePath (true om man inte vill skriva över data, false om man vill)
            using (StreamWriter writer = new StreamWriter(filePath, true)
            
        }

        //Tar bort information i textfilen
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name)) return;
        }

        //Uppdaterar information i textfilen
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string fileUpdate = @"C:\Addressbook\adressbook.txt";
        }

        //Söker efter data i filen och skriver ut och sorterar
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
