)
# InterestingDigitalClockProblem
Clarks Codility Interesting Digital Clock Problem

Problem Statement :

In this task we consider interesting pattersn that could be observer on a digital clock. Such clock displays current time using the format "HH:MM:SS" where 
 
- "HH" is the hour of day (00 to 23)
- "MM" is the minute of the day (00 to 59)
- "SS" is the second of the day (00 to 59)

Note : hour, minute and second represented as two digits

We say that a point in time is interesting if digital clock needs at most two distinct number to display it.

For example :

13:31:33 and 02:20:22 are both interesting, because digital clock can display it using only 1 and 3 in the first case, 
and 0 and 2 in second case.

Write a function: class Solutim { public int solution(string S, string T); } 

that, given strings S and T representing time in the format : : ss',
retums the number of interesting points in time between S and T (inclusive).

For example, given "15 : 15 : ee" and "15 : 15 : 12", your function should retum 1,
because there is only one interesting point in time between these points (namely "15 : 15 : 11"), 
Given "22:22 : 21" and "22 : 22 : 23", your function should return 3; 
interesting points in time are "22 : 22: 21", '22 : 22: 22", and '22 : 22:23". 
Assume that:
• strings S and T follow the format 'HH:W: ss" strictly;
• string S describes a point in time before T on the same day. 

Test Output In your solution, focus on correctness. The performance of your solution will not be the focus of the assessment. 

Copyright 2009—2019 by Codility Limited. All Rights Reserved. Unauthorized copying, or disclosure
