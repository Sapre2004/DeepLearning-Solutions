using System;
using System.Collections.Generic;

namespace EcommerceSearch
{
    public static class SearchAlgorithms
    {
        // Linear Search: O(n)
        public static Product LinearSearch(List<Product> products, string targetName)
        {
            foreach (var product in products)
            {
                if (product.ProductName.Equals(targetName, StringComparison.OrdinalIgnoreCase))
                    return product;
            }
            return null;
        }

        // Binary Search: O(log n)
        public static Product BinarySearch(Product[] sortedProducts, string targetName)
        {
            int low = 0;
            int high = sortedProducts.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int compare = string.Compare(sortedProducts[mid].ProductName, targetName, StringComparison.OrdinalIgnoreCase);

                if (compare == 0)
                    return sortedProducts[mid];
                else if (compare < 0)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return null;
        }
    }
}
