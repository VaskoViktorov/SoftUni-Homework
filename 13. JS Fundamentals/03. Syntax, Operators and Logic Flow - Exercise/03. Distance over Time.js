function distance([a,b,c]) {
    a = a*1000;
    b = b*1000;
    c = c/3600;

 let first = a*c;
 let second = b*c;

 return Math.abs(first-second);
}