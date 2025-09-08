class Solution {
public:
  vector<int> twoSum(vector<int>& nums, int target) {
map<int,int>mp;
vector<pair<int,int>>v;
    for (int i = 0; i < nums.size(); ++i) {
       v.push_back({nums[i],i});
    }
    sort(v.begin(), v.end());
    int start=0,end=nums.size()-1;
    while (start<end){
        if (v.at(start).first+v.at(end).first==target)
            return {v.at(start).second,v.at(end).second};
        else{
            if (v.at(start).first+v.at(end).first>target){
                end--;
            } else{
                start++;
            }
            
        }
    }
    return {-1};
    
}
};