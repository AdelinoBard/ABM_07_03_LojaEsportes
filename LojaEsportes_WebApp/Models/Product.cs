using System.ComponentModel.DataAnnotations.Schema;

namespace LojaEsportes_WebApp.Models {
    public class Product {

        public long? ProductID { get; set; }
        
        public string Name { get; set; } = String.Empty;
        
        public string Description { get; set; } = String.Empty;
        
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        
        public string Category { get; set; } = String.Empty;
    }
}

// A propriedade Price foi decorada com o atributo Column para especificar o tipo de dado SQL que será usado para armazenar valores para essa propriedade. Nem todos os tipos C# mapeiam perfeitamente para tipos SQL, e esse atributo garante que o banco de dados use um tipo apropriado para os dados do aplicativo.