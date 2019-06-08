
/*************************************************************
 *  Optimized  Solution 1
-*************************************************************/
function arithmicSum(n) {
    return (n * (n + 1)) / 2
}

function arithmicSequence(limit)  {
    limit = limit -1;
    const threes = 3 * arithmicSum(Math.floor(limit/3));
    const fives = 5 * arithmicSum(Math.floor(limit/5));
	const fifteens = 15 * arithmicSum(Math.floor(limit/15));
	return parseInt(threes + fives - fifteens)
}
let n =100
console.log(arithmicSequence(n))

/*************************************************************
 *  Optimized  Solution 2
-*************************************************************/

function sumDivisbleBy( n,  p){
    // n*((p/n) * (p/n)+1)/2
    const ratio = parseInt(p / n)
    const  sum = n * (ratio * (ratio + 1) )/ 2;
    return sum;
}

function sumOfNumbersDivisbleBy(n)
{
    n=n-1
    return  sumDivisbleBy(3,n)+sumDivisbleBy(5,n)-sumDivisbleBy(15,n);
}


console.log(sumOfNumbersDivisbleBy(n));