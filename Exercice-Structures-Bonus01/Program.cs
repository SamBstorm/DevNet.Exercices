using System;
using System.Collections.Generic;

namespace Exercice_Structures_Bonus01
{
    class Program
    {
        static void Main(string[] args)
        {
            Email sam_email;
            sam_email.pseudoMail = "samuel.legrain";
            sam_email.domaine = "bstorm.be";

            Email anto_email;
            anto_email.pseudoMail = "antonio";
            anto_email.domaine = "technobel.be";

            //Console.WriteLine($"{sam_email.pseudoMail}@{sam_email.domaine}");
            //Console.WriteLine($"{anto_email.pseudoMail}@{anto_email.domaine}");

            Telephone sam_number;
            sam_number.idxPays = 32;
            sam_number.idxReg = 800;
            sam_number.numero = 33800;

            //Console.WriteLine($"+{sam_number.idxPays}-(0){sam_number.idxReg}/{sam_number.numero}");

            Contact sam_contact;
            sam_contact.nom = "Legrain";
            sam_contact.prenom = "Samuel";
            sam_contact.dateDeNaissance = new DateTime(1987,9,27);
            sam_contact.emails = new List<Email>();
            sam_contact.emails.Add(sam_email);
            sam_contact.emails.Add(anto_email);
            sam_contact.telephones = new List<Telephone>();
            sam_contact.telephones.Add(sam_number);

            Console.WriteLine($"{sam_contact.nom} {sam_contact.prenom}");
            Console.WriteLine($"Né le {sam_contact.dateDeNaissance}");
            foreach (Email mail in sam_contact.emails)
            {
                Console.WriteLine($"{mail.pseudoMail}@{mail.domaine}");
            }
            foreach (Telephone phone in sam_contact.telephones)
            {
                Console.WriteLine($"+{phone.idxPays}-(0){phone.idxReg}/{phone.numero}");
            }
        }
    }
}
