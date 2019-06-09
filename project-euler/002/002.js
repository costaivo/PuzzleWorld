function fiboEvenSum(number) {
  let first = 1,
    second = 2,
    curFib = 3,
    sum = 0;

  if (number <= 1) return sum;
  else sum = 2;

  for (let i = 2; i <= number; i++) {
    curFib = first + second;
    if (curFib % 2 === 0) sum += curFib;

    first = second;
    second = curFib;
  }
  return sum;
}


var nums = fiboEvenSum(4000000)
console.log(nums)