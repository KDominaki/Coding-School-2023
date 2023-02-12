namespace PetShop.Model
{
    public class Transaction
    {
        public Transaction(decimal petPrice, int petFoodQty, decimal petFoodPrice)
        {
            Date = DateTime.Now;
            PetPrice = petPrice;
            PetFoodPrice = petFoodPrice;
            PetFoodQty = petFoodQty;
            TotalPriceCalc();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal PetPrice { get; set; }
        public int PetFoodQty { get; set; }
        public decimal PetFoodPrice { get; set; }
        public decimal TotalPrice { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;

        public int PetId { get; set; }
        public Pet Pet { get; set; } = null!;

        public int PetFoodId { get; set; }
        public PetFood PetFood { get; set; } = null!;

        // Methonds
        public void TotalPriceCalc()
        {
            if (PetPrice != 0)
            {
                PetFoodQty += 1;
                TotalPrice = (PetFoodQty * PetFoodPrice) - PetFoodPrice + PetPrice;
            }
            else
            {
                TotalPrice = (PetFoodQty * PetFoodPrice) + PetPrice;
            }
        }
    }

    public class TransactionCreateDto
    {
        public decimal PetPrice { get; set; }
        public int PetFoodQty { get; set; }
        public decimal PetFoodPrice { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int PetId { get; set; }
        public int PetFoodId { get; set; }
    }
    public class TransactionEditDto
    {
        public int Id { get; set; }
        public decimal PetPrice { get; set; }
        public int PetFoodQty { get; set; }
        public decimal PetFoodPrice { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int PetId { get; set; }
        public int PetFoodId { get; set; }
    }
    public class TransactionDeleteDto
    {
        public int Id { get; set; }
        public decimal PetPrice { get; set; }
        public int PetFoodQty { get; set; }
        public decimal PetFoodPrice { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int PetId { get; set; }
        public int PetFoodId { get; set; }
    }
}
