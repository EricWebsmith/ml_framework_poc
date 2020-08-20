# UI

First, let's look at the UI.

![ui](images/ui.png)

From this UI, we can generate a config.json file which is consumed by the backend.



You can click the buttons in the left to add workflow nodes to the workflow section in the middle.



You can right click the workflow nodes to move up, move down or delete the workflow node.



In the property section, the properties of the nodes are set.



The UI is release [here](https://github.com/EricWebsmith/ml_framework_poc/releases/tag/1).

# Backend

The backend will use this config.json to build a model.



```pyhton
python job_executor.py config.json
```



# Unit Test

As we can see, each time we execute the workflow, a configuration file will be generated. We can save those files and use them in unit test. 



The unit test is quite easy to write:



```python 
import unittest
import job_executor

class MLTests(unittest.TestCase):

    def test_1(self):
        job_executor.execute("test_case_1_lr.json")

    def test_2(self):
        job_executor.execute("test_case_2_decision_tree.json")

if __name__ == '__main__':
    unittest.main()
```

