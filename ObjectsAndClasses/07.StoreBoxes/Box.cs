namespace _07.StoreBoxes
{
	class Box
	{
		public Box()
		{
			Item = new Item();
		}
		public string SerialNumber { get; set; }
		public string ItemName { get; set; }
		public int Quantity { get; set; }
		public double PriceForBox { get; set; }

		public Item Item { get; set; }
	}
}
