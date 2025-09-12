static int Ceiling(int[] arr, int target) {
    int left = 0;
    int right = arr.Length - 1;
    
    while (left <= right) {
        int mid = left + (right - left) / 2;
        
        if (arr[mid] > target) {
            right = mid - 1;
        } else if (arr[mid] < target) {
            left = mid + 1;
        } else {
            return mid;  
        }
    }
    
    return left < arr.Length ? left : -1;
}

static int Floor(int[] arr, int target) {
    int left = 0;
    int right = arr.Length - 1;
    
    while (left <= right) {
        int mid = left + (right - left) / 2;
        
        if (arr[mid] > target) {
            right = mid - 1;
        } else if (arr[mid] < target) {
            left = mid + 1;
        } else {
            return mid;  
        }
    }
    
    return right >= 0 ? right : -1;
}