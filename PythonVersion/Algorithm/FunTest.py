from Easy.Arrar03 import Solution

k=3
a=[1,2,3,4,5,6]
a.reverse()
print(a)
temp=a[0:k]
temp2=a[k:len(a)]
temp.reverse()
temp2.reverse()
a=temp+temp2
print(a)
