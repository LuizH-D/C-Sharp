namespace CoursesPortal.Entities {
    class Student {
        public int Registration { get; set; }
        

        public Student() {
        }

        public Student(int registration) {
            Registration = registration;
        }

        public override int GetHashCode() {
            return Registration.GetHashCode();
        }

        public override bool Equals(object obj) {
            if (!(obj is Student)) {
                return false;
            }

            Student other = obj as Student;
            return Registration.Equals(other.Registration);
        }
    }
}
