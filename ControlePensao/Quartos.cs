namespace ControlePensao {
    class Quartos {

        public string nome { get; set; }
        public string email{ get; set; }
        public int numQuartos { get; set; }

        public Quartos(string _nome,string _email, int _numquarto) {
            nome = _nome;
            email = _email;
            numQuartos = _numquarto;
        }

        public override string ToString() {
            return numQuartos+","+nome+","+email;
        }

    }
}
