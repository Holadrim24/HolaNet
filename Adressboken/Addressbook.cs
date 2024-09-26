using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.Drawing;
using System;
using System.Reflection.PortableExecutable;

namespace Adressboken
{

//Uppgiften handlar om att skapa en adressbok. All information skall sparas i en textfil.
//Det betyder att applikationen skall kunna l�sa och skriva fr�n denna textfil. Gr�nssnittet till
//applikationen skall skapas i Windows Forms. Krav f�r att uppgiften skall bli godk�nd:
//
//1. F�ljande information skall kunna registreras och sparas till textfilen, namn, gatudress,
//postnummer, postort, telefon och epost
//
//2. Det skall g� att spara en ny adress i adressboken men ocks� uppdatera en adress som
//   redan finns.
//
//3. Det skall g� att ta bort en adress och den skall d� f�rsvinna fr�n adressboken.
//
//4. Det skall g� att s�ka p� en eller flera adresser och s�kresultatet skall visas i en lista.
//   Fr�n listan skall det g� att klicka p� en rad och f� upp all information om den adressen.
//
//5. S�kningen skall fungera som ett urval d�r det minst skall g� att g�ra urval p� namn
//   och postort.
//
//Koden skall fungera och applikationen skall g� att k�ra utan fel
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

            //Skapar en s�kv�g till filen p� h�rddisken
            string filePath = @"C:\Addressbook\adressbook.txt";
            //Skapar en StreamWriter som pekar p� filePath (true om man inte vill skriva �ver data, false om man vill)
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

        //S�ker efter data i filen och skriver ut och sorterar
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
