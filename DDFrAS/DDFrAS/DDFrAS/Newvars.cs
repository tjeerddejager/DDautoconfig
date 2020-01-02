﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Text;
using Renci.SshNet;
using Renci.SshNet.Sftp;

namespace DDFrAS.DDFrAS
{
    public class Newvdbinputs
    {
        //insert new variables into database

        public static void Newvars(string vlan, string manip, string username, string passwordssh, string terminal)
        {
            using (DDFrASEntities context = new DDFrASEntities())
            {
                CONFIG_VAR configvar = new CONFIG_VAR
                {
                    //Vlan = vlan,
                    //Man_IP = manip,
                    //Username = username,
                    //PasswordSSH = passwordssh,
                    //Terminal = terminal
                };
                context.CONFIG_VAR.Add(configvar);
                context.SaveChanges();
            }
        }

        //insert new script into database

        public static void NewScript(string script, DateTime executedate, int id)
        {
            using (DDFrASEntities context = new DDFrASEntities())
            {
                CONFIG configscript = new CONFIG
                {
                    Command_ID = id,
                    Script = script,
                    ExDate = executedate,
                    Status = 0
                };
                context.CONFIGs.Add(configscript);
                context.SaveChanges();

            }

        }

        //insert new switch into database

        public static void NewSwitch(string ssh_password, string ssh_username, string term_password, string man_ip)
        {
            using (DDFrASEntities context = new DDFrASEntities())
            {
                SWITCH newswitch = new SWITCH
                {
                    //SSH_Password = ssh_password,
                    //SSH_Username = ssh_username,
                    //Term_Password = term_password,
                    //Man_IP = man_ip
                };
                context.SWITCHes.Add(newswitch);
                context.SaveChanges();

            }

        }

        //public StringBuilder Resultssh(StringBuilder result)
        //{
        //    return result;
        //}

        //public static void ssh_connection(string ip, string username, string userpassword, string enablepass, string command)
        //{
        //    StringBuilder result = new StringBuilder();
        //    var client = new SshClient(ip, username, userpassword);
        //    client.Connect();
        //    result.Append(client.RunCommand(command).Execute() + "\r\n");


        //}

    }

}
