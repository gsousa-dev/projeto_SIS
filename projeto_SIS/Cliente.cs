﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_SIS
{
    class Cliente
    {
        private int id, user_type, status, created_at, updated_at;
        private string username, auth_key, password_hash, password_reset_token, email, name, birthday, gender, profile_picture;


        public Cliente(int id, int user_type, string username, string auth_key, string password_hash, string password_reset_token, string email, int status, int created_at, int updated_at, string name, string birthday, string gender, string profile_picture, int idPersonalTrainer)
        {
            this.id = id;
            this.user_type = user_type;
            this.username = username;
            this.auth_key = auth_key;
            this.password_hash = password_hash;
            this.password_reset_token = password_reset_token;
            this.email = email;
            this.status = status;
            this.created_at = created_at;
            this.updated_at = updated_at;
            this.name = name;
            this.birthday = birthday;
            this.gender = gender;
            this.profile_picture = profile_picture;
        }


        public int ID { get { return id; } }
        public string Username { get { return username; } }
        public string Email { get { return email; } }
        public string Name { get { return name; } }
        public string Birthday { get { return birthday; } }
        public string Gender { get { return gender; } }


        public override string ToString()
        {
            return "Username: " + username + " | Email: " + email + " | Nome: " + name + " | Data de Nascimento: " + birthday + " | Genero: " + gender;
        }
    }
}
