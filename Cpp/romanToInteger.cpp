/*Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.
Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:
•	I can be placed before V (5) and X (10) to make 4 and 9. 
•	X can be placed before L (50) and C (100) to make 40 and 90. 
•	C can be placed before D (500) and M (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer.
 
Example 1:
Input: s = "III"
Output: 3
Example 2:
Input: s = "IV"
Output: 4
Example 3:
Input: s = "IX"
Output: 9
Example 4:
Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.
Example 5:
Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
 
Constraints:
•	1 <= s.length <= 15
•	s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
•	It is guaranteed that s is a valid roman numeral in the range [1, 3999].
Prev
1 / 2
Next
*/

#include<iostream>

using namespace std;

class Solution {
public:
    int romanToInt(string s) {
        int val = 0;
        int count = 0;
        string::iterator itr, itr2;
        int A[s.length()];
            for(itr = s.begin(), itr2 = s.begin()+1; itr != s.end() && itr2 != s.end(); itr++, itr2++){ 
                if(romanToDigit(itr)<romanToDigit(itr2)){
                    A[count] = -1;
                }
                else{
                    A[count] = 1;
                }
                //cout <<A[count]<<endl;
            count++;
             }
        A[count] = 1;
        count = 0;
        for(itr = s.begin(); itr != s.end() ; itr++){ 
        
            val = val + romanToDigit(itr)*A[count];
            count++;
        }
               
    return val;
    }
    int romanToDigit(string::iterator itr){
        int val = 0;
        switch(*itr){
                        case 'I':
                            val = 1;
                            break;
                        case 'V':
                            val = 5;
                            break;
                        case 'X':
                            val = 10;
                            break;
                        case 'L':
                            val = 50;
                            break;
                        case 'C':
                            val = 100;
                            break;
                        case 'D':
                            val = 500;
                            break;
                        case 'M':
                            val = 1000;
                            break;
                        default:
                            break;
    }
        return val;
    }
};

int main(){
    string s;
    cout<< "Enter a roman string in caps" << endl;
    getline(cin, s) ;
    Solution res;
    cout<<  res.romanToInt(s) << endl;
    return 0;
}