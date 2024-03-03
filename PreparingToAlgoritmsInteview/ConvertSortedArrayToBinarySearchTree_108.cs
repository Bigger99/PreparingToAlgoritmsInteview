namespace PreparingToAlgoritmsInteview;

internal class ConvertSortedArrayToBinarySearchTree_108
{
    public ConvertSortedArrayToBinarySearchTree_108()
    {
        var arr1 = new[] { -10, -3, 0, 5, 9 };
        var res1 = SortedArrayToBST(arr1);
        var arr2 = new[] { 1, 3 };
        var res2 = SortedArrayToBST(arr2);
    }

    public TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums.Length <= 0)
            return null;

        var root = new TreeNode(nums[0]);
        var temp = root;

        //for (var i = 1; i < nums.Length; i++)
        //{
        //    var nexNum = nums[i];
        //    var isInserted = false;

        //    while (!isInserted)
        //    {
        //        if (nexNum)
        //        {
        //            temp.val = item;
        //            break;
        //        }
        //    }
        //} 

        //if (nums.Length <= 0)
        //    return null;

        //var root = new TreeNode(nums[0]);
        //var temp = root;

        //for (var i = 1; i < nums.Length; i++)
        //{
        //    var nexNum = nums[i];
        //    var isInserted = false;

        //    while (!isInserted)
        //    {
        //        if (nexNum >= temp.val)
        //        {
        //            if (temp.right is null)
        //            {
        //                temp.right = new TreeNode(nexNum);
        //                isInserted = true;
        //            }
        //            else
        //            {
        //                temp = temp.right;
        //            }
        //        }
        //        else
        //        {
        //            if (temp.left is null)
        //            {
        //                temp.left = new TreeNode(nexNum);
        //                isInserted = true;
        //            }
        //            else
        //            {
        //                temp = temp.right;
        //            }
        //        }
        //    }

        //    temp = root;
        //}

        return root;
    }
}

//public class TreeNode
//{
//      public int val;
//      public TreeNode left;
//      public TreeNode right;

//      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
//      {
//        this.val = val;
//        this.left = left;
//        this.right = right;
//      }
//}
