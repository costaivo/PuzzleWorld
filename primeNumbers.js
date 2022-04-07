function isPrimeNumber(n){
  let i=2
  if(n===1)
    return true
  
  while(i<n){
    console.log(i)
    if(n%i===0){
    	console.log(`${i} is divisible by ${n}`)
      return false
    
    }
    i++
  }
  return true
}

console.log(isPrimeNumber(3))