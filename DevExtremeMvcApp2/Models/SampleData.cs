using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExtremeMvcApp2.Models {
    static class SampleData {
        public static List<Person> Persons = new List<Person>() {
            new Person {
                PersonID = 10001,
                PersonName = "廖先生",
                PersonAddress="台中市"

            },
            new Person {
                PersonID = 10002,
                PersonName = "吳先生",
                PersonAddress="台中市"
            },
            new Person {
                PersonID = 10003,
                PersonName = "廖小明",
                PersonAddress="彰化市"
            },
            new Person {
                PersonID = 10004,
                PersonName = "陳先生",
                PersonAddress="台中市"
            },
        };
    }
}
