#include <iostream>
using namespace std;
int main()
{
	printf("%d", 7);

}


// Print a rotated Matrix
//vector<int> Solution::rotateArray(vector<int> &A, int B) {
//	vector<int> ret;
//	for (int i = 0; i < A.size(); i++) {
//		ret.push_back(A[(i + B) % A.size()]);
//	}
//	return ret;
//}

//===============================================================================================

//int Solution::gcd(int A, int B) {
//	// Do not write main() function.
//	// Do not read input, instead use the arguments to the function.
//	// Do not print the output, instead return values as specified
//	// Still have a doubt. Checkout www.interviewbit.com/pages/sample_codes/ for more details
//	if (A == 0 || B == 0)
//		return A > 0 ? A : B;
//	if (A > B)
//		return gcd(A%B, B);
//	else
//		return gcd(B%A, A);
//
//}

//===============================================================================================

/**
* Definition for singly-linked list.
* struct ListNode {
*     int val;
*     ListNode *next;
*     ListNode(int x) : val(x), next(NULL) {}
* };
*/
/**
* Definition for singly-linked list.
* struct ListNode {
*     int val;
*     ListNode *next;
*     ListNode(int x) : val(x), next(NULL) {}
* };
*/
/**
* Definition for singly-linked list.
* struct ListNode {
*     int val;
*     ListNode *next;
*     ListNode(int x) : val(x), next(NULL) {}
* };
*/
//ListNode* Solution::detectCycle(ListNode* A) {
//	// Do not write main() function.
//	// Do not read input, instead use the arguments to the function.
//	// Do not print the output, instead return values as specified
//	// Still have a doubt. Checkout www.interviewbit.com/pages/sample_codes/ for more details
//	if (A == NULL || A->next == NULL)
//		return NULL;
//
//	ListNode* Fptr = A;
//	ListNode* Sptr = A;
//	bool isCyclic = false;
//
//	while (Fptr != NULL && Sptr != NULL)
//	{
//		Fptr = Fptr->next;
//		if (Sptr->next == NULL)
//		{
//			return NULL;
//		}
//		Sptr = Sptr->next->next;
//		if (Fptr == Sptr)
//		{
//			isCyclic = true;
//			break;
//		}
//	}
//	if (!isCyclic)
//		return NULL;
//
//	Fptr = A;
//	while (Sptr != Fptr)
//	{
//		Fptr = Fptr->next;
//		Sptr = Sptr->next;
//	}
//
//
//	return Fptr;
//}

//===============================================================================================

/**
* Definition for singly-linked list.
* struct ListNode {
*     int val;
*     ListNode *next;
*     ListNode(int x) : val(x), next(NULL) {}
* };
*/
//ListNode* Solution::deleteDuplicates(ListNode* A) {
//	// Do not write main() function.
//	// Do not read input, instead use the arguments to the function.
//	// Do not print the output, instead return values as specified
//	// Still have a doubt. Checkout www.interviewbit.com/pages/sample_codes/ for more details
//
//	ListNode* current = A;
//	while (current != NULL)
//	{
//		while (current->next != NULL && current->val == current->next->val)
//		{
//			current->next = current->next->next;
//		}
//		current = current->next;
//	}
//
//	return A;
//
//}
