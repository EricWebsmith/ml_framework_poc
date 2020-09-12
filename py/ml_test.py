import unittest
import job_executor

class MLTests(unittest.TestCase):

    def test_lr(self):
        job_executor.execute("test_case_1_lr.json")

    def test_dt(self):
        job_executor.execute("test_case_2_decision_tree.json")

    def test_gdbt(self):
        job_executor.execute("test_case_3_gdbt.json")

    def test_csv(self):
        job_executor.execute("test_case_4_csv.json")

    def test_linear_regressor(self):
        job_executor.execute("test_case_5_linear_regressor.json")

    def test_elastic_net(self):
        job_executor.execute("test_case_6_elastic_net.json")

if __name__ == '__main__':
    unittest.main()