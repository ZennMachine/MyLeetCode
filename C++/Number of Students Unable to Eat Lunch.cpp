// https://leetcode.com/problems/number-of-students-unable-to-eat-lunch/submissions/1226638341

class Solution {
public:
    int countStudents(vector<int>& students, vector<int>& sandwiches) {
        int len = students.size();
        queue<int> studentQueue;
        stack<int> sandwichStack;

        for(int i = 0; i < len; i++)
        {
            studentQueue.push(students[i]);
            sandwichStack.push(sandwiches[len - i - 1]);
        }

        int lastServed = 0;

        while(studentQueue.size() > 0 && studentQueue.size() > lastServed)
        {
            if(studentQueue.front() == sandwichStack.top())
            {
                studentQueue.pop();
                sandwichStack.pop();
                lastServed = 0;
            }
            else
            {
                studentQueue.push(studentQueue.front());
                studentQueue.pop();
                lastServed++;
            }
        }

        return studentQueue.size();
    }
};