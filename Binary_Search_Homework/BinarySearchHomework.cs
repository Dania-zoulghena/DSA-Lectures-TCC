using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: write code for the ternary search algorithm and return the index of the element
            while (start <= end)
            {
                int mid1 = start + ((end - start) / 3);
                int mid2 = end - ((end - start) / 3);

                if (arr[mid1] == key)
                {
                    return mid1 + 1;
                }

                if (arr[mid2] == key)
                {
                    return mid2 + 1;
                } 

                if (key < arr[mid1])
                {
                    end = mid1 - 1;
                }
                else if (key > arr[mid2])
                {
                    start = mid2 + 1;
                }
                else
                {
                    start = mid1 + 1;
                    end = mid2 - 1;
                }
            }
            return -1;
        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance
            int firstOccurrence = -1;

            // البحث عن أول حدوث للعدد المستهدف
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] == key)
                {
                    firstOccurrence = mid;
                    end = mid - 1; // البحث عن المزيد في الجزء الأيسر
                }
                else if (arr[mid] < key)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            if (firstOccurrence == -1)
            {
                return 0; // لم يتم العثور على العدد المستهدف
            }

            // البحث عن آخر حدوث للعدد المستهدف
            int lastOccurrence = firstOccurrence;
            end = arr.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] == key)
                {
                    lastOccurrence = mid;
                    start = mid + 1; // البحث عن المزيد في الجزء الأيمن
                }
                else if (arr[mid] < key)
                    start = mid + 1;

                else
                    end = mid - 1;
            }

            return lastOccurrence - firstOccurrence + 1; // عدد مرات التكرار            return -1;
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method
        int count = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == key)
                    count++;
            return count;
        }
    }

        }
    }
}
