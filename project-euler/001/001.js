
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
    const  sum = n * (parseInt(p / n)) * ((parseInt(p / n)) + 1) / 2;
    return sum;
}

function sumOfNumbersDivisbleBy(num1,num2,n)
{
    n=n-1
    return  sumDivisbleBy(num1,n)+sumDivisbleBy(num2,n)-sumDivisbleBy(num1*num2,n);
}


console.log(sumOfNumbersDivisbleBy(3,5,n));