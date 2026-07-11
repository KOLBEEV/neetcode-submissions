class Solution {
public:
	vector<int> topKFrequent(vector<int>& nums, int k) {
		unordered_map<int, int> nums_with_count;

		for (int& num : nums) {
			if (nums_with_count.find(num) != nums_with_count.end()) {
				nums_with_count[num]++;
				continue;
			}

			nums_with_count[num] = 1;
		}

		vector<pair<int, int>> sorted(nums_with_count.begin(), nums_with_count.end());

		sort(
			sorted.begin(),
			sorted.end(),
			[](const pair<int, int>& a, const pair<int, int>& b) { return a.second > b.second; }
		);

		vector<int> result;

		for (int i = 0; i < k; i++) {
			result.push_back(sorted[i].first);
		}

		return result;
	}
};