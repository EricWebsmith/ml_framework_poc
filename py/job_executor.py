import json

def my_import(name):
    components = name.split('.')
    mod = __import__(components[0])
    for comp in components[1:]:
        mod = getattr(mod, comp)
    return mod

def execute(config_file):
    config=json.load(open(config_file))
    inputs = {}
    results = []
    for step in config['pipepline']:
        #print(step)
        the_class=my_import(step["class"])
        obj=the_class()
        mod_config = step['mod_config']
        inputs=obj.execute(inputs, mod_config)
        results.append(inputs['data'])

