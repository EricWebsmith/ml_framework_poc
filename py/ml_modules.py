import numpy as np
import pandas as pd


class CsvImporter():
    def execute(self, inputs:dict, mod_config:dict):
        csv_path=mod_config['filepath']
        data=pd.read_csv(csv_path)
        return {"data":data}

class FeatureSelector():
    def execute(self, inputs:dict, mod_config:dict):
        data=inputs["data"]
        columns = mod_config['columns'].split(",")
        data=data[columns]
        return {"data":data}

class OrdinalEncoder():
    def execute(self, inputs:dict, mod_config:dict):
        data=inputs["data"]
        columns = mod_config['columns'].split(",")
        for column in columns:
            values = data[column].unique()
            length=len(values)
            dict_temp={}
            for i in range(length):
                dict_temp[values[i]]=i
            data[column]=data[column].apply(dict_temp.get)
            data[column]=data[column].astype(int)
        return {"data":data}

class OneHotEncoder():
    def execute(self, inputs:dict, mod_config:dict):
        data=inputs["data"]
        columns = mod_config['columns'].split(",")
        for column in columns:
            values = data[column].unique()
            length=len(values)
            dict_temp={}
            for i in range(length):
                dict_temp[values[i]]=i
            data[column]=data[column].apply(dict_temp.get)
            data[column]=data[column].astype(int)
        return {"data":data}

class LogisticRegressor():
    def execute(self, inputs:dict, mod_config:dict):
        from sklearn.linear_model import LogisticRegression
        from sklearn.model_selection import train_test_split
        from joblib import dump
        data=inputs["data"]
        features = mod_config['features'].split(",")
        X=data[features]
        label = mod_config['label']
        y=data[label]
        X_train, X_test, y_train, y_test = train_test_split(X, y)
        model = LogisticRegression()
        model.fit(X_train, y_train)
        score = model.score(X_test, y_test)
        print(f'score {score}')

        model_path= mod_config['model_path']
        dump(model, model_path)

        return {"data":"success", "score": score}

class DecisionTreeClassifier():
    def execute(self, inputs:dict, mod_config:dict):
        from sklearn.tree import DecisionTreeClassifier
        from sklearn.model_selection import train_test_split
        from joblib import dump
        data=inputs["data"]
        features = mod_config['features'].split(",")
        X=data[features]
        label = mod_config['label']
        y=data[label]
        X_train, X_test, y_train, y_test = train_test_split(X, y)

        max_depth = mod_config['max_depth']

        model = DecisionTreeClassifier(max_depth=max_depth)
        model.fit(X_train, y_train)
        score = model.score(X_test, y_test)

        print(f'score {score}')

        model_path= mod_config['model_path']
        dump(model, model_path)
        return {"data":"success", "score": score}

class GradientBoostingClassifier():
    def execute(self, inputs:dict, mod_config:dict):
        from sklearn.ensemble import GradientBoostingClassifier
        from sklearn.model_selection import train_test_split
        from joblib import dump
        data=inputs["data"]
        features = mod_config['features'].split(",")
        X=data[features]
        label = mod_config['label']
        y=data[label]
        X_train, X_test, y_train, y_test = train_test_split(X, y)
        n_estimators = mod_config['n_estimators']
        max_depth = mod_config['max_depth']

        model = GradientBoostingClassifier(n_estimators=n_estimators, max_depth=max_depth)
        model.fit(X_train, y_train)
        score = model.score(X_test, y_test)

        print(f'score {score}')

        model_path= mod_config['model_path']
        dump(model, model_path)
        return {"data":"success", "score": score}
    
class CsvExporter():
    def execute(self, inputs:dict, mod_config:dict):
        data=inputs["data"]
        if type(data) is np.ndarray:
            data=pd.DataFrame(data)
        elif type(data) is pd.core.frame.DataFrame:
            pass
        else:
            print(type(data))
            raise NotImplementedError("Subclasses should implement this!")
        file_path=mod_config['filepath']
        data.to_csv(file_path, index=False)
        return {"data":"success"}
