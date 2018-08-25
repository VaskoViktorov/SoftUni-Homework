function compoundInterest([p,i,n,t]) {
    n = 12/n;
    let compound = p*Math.pow(1+i/(100*(n)),n*t);

    return compound.toFixed(2);
}