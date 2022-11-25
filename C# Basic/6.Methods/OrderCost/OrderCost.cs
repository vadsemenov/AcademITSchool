using System;

namespace OrderCost
{
    public class OrderCost
    {
        private const int GoodsCostDiscountMinThreshold = 1_000;
        private const int GoodsAmountDiscountMinThreshold = 10;
        private const double BigDiscount = 0.9;
        private const double SmallDiscount = 0.95;

        public static void Main(string[] args)
        {
            int goodsType1Quantity = GetIntNumberFromConsole("Введите количество первого товара:");
            double goodsType1Price = GetDoubleNumberFromConsole("Введите стоимость первого товара:");

            int goodsType2Quantity = GetIntNumberFromConsole("Введите количество второго товара:");
            double goodsType2Price = GetDoubleNumberFromConsole("Введите стоимость второго товара:");

            Console.WriteLine("Стоимость заказа с учетом скидок - " + GetOrderCostWithDiscount(goodsType1Quantity,
                goodsType1Price, goodsType2Quantity, goodsType2Price));

            Console.Read();
        }

        private static double GetOrderCostWithDiscount(int goodsType1Quantity, double goodsType1Price,
            int goodsType2Quantity, double goodsType2Price)
        {
            double totalOrderCost = goodsType1Price * goodsType1Quantity + goodsType2Price * goodsType2Quantity;
            int totalOrderGoodsQuantity = goodsType1Quantity + goodsType2Quantity;

            double totalOrderCostWithDiscount = totalOrderCost;

            if (totalOrderCost >= GoodsCostDiscountMinThreshold &&
                totalOrderGoodsQuantity >= GoodsAmountDiscountMinThreshold)
            {
                return totalOrderCost * BigDiscount;
            }

            if (totalOrderCost >= GoodsCostDiscountMinThreshold)
            {
                totalOrderCostWithDiscount *= SmallDiscount;
            }
            else if (totalOrderGoodsQuantity >= GoodsAmountDiscountMinThreshold)
            {
                totalOrderCostWithDiscount *= SmallDiscount;
            }

            return totalOrderCostWithDiscount;
        }

        private static int GetIntNumberFromConsole(string message)
        {
            Console.WriteLine(message);

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }

                Console.WriteLine("Введено неверное значение. Введите снова.");
            }
        }

        private static double GetDoubleNumberFromConsole(string message)
        {
            Console.WriteLine(message);

            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double result))
                {
                    return result;
                }

                Console.WriteLine("Введено неверное значение. Введите снова.");
            }
        }
    }
}