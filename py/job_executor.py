import json
import sys

def my_import(name):
    components = name.split('.')
    mod = __import__(components[0])
    for comp in components[1:]:
        mod = getattr(mod, comp)
    return mod

def execute(config_file):
    config={}
    with open(config_file) as f:
        config=json.load(f)
        f.close()
    inputs = {}
    results = []
    for node_config in config['pipepline']:
        the_class=my_import(node_config["class"])
        obj=the_class()
        inputs=obj.execute(inputs, node_config)
        results.append(inputs['data'])

if __name__=="__main__":
    print("start")
    config_file=sys.argv[1]
    execute(config_file)
    print("DONE")