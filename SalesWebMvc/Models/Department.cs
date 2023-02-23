﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebMvc.Models
{
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        //Cria uma coleção de seller e ja instancia
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department() { }

        public Department(string name)
        {
            Name = name;

        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            //Chama a função soma em Sellers (Sellers.Sum)
            //Despois, em cada vendedor (seller) na lista sera aplicada a função TotalSales do inicio ao fim
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}