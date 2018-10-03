class Profile:
    __name = None  # __ = private
    __yrke = None  # annars GLOBAL
    __age = None
    __country = None

    def __init__(self, name, age, yrke, country):
        self.__name = name
        self.__yrke = yrke
        self.__country = country
        self.__age = age

    def set_name(self, name):
        self.__name = name

    def set_yrke(self, yrke):
        self.__yrke = yrke

    def set_country(self, country):
        self.__country = country

    def set_age(self, age):
        self.__age = age

    def get_name(self):
        return self.__name

    def get_yrke(self):
        return self.__yrke

    def get_country(self):
        return self.__country

    def get_age(self):
        return self.__age


class PersonalInfo(Profile):
    __hobbies = None
    __sex = None
    __length = None

    def __init__(self, name, age, yrke, country, hobbies, sex, length, ):
        self.__hobbies = hobbies
        self.__sex = sex
        self.__length = length
        super().__init__(name, age, yrke, country)

    def set_hobbies(self, hobbies):
        self.set__hobbies = hobbies

    def get_hobbies(self):
        return self.__hobbies

    def set_sex(self, sex):
        self.set__sex = sex

    def get_sex(self):
        return self.__sex

    def set_lenght(self, length):
        self.__length = length

    def get_length(self):
        return self.__length

