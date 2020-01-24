static List<int[]> PrimeFactorization(int n){

	    List<int[]> arr = new List<int[]>();
	    int temp = n;

	    for(int i=2;i<=Math.Ceiling(Math.Sqrt(n));i++){
	        if(temp%i==0){
	            int count = 0;
	            while(temp%i==0){
	                count++;
	                temp /= i;
	            }
	            arr.Add(new int[2]{i,count});
	        }
	    }

	    if(temp != 1){
	        arr.Add(new int[2]{temp,1});
	    }

	    if(arr.Count() == 0){
	        arr.Add(new int[2]{n,1});
	    }


	    return arr;
	}
