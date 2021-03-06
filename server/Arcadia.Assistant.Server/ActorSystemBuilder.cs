﻿namespace Arcadia.Assistant.Server
{
    using Akka.Actor;
    using Akka.DI;
    using Akka.DI.Core;

    using Arcadia.Assistant.Helpdesk;
    using Arcadia.Assistant.Organization;

    public class ActorSystemBuilder
    {
        private readonly ActorSystem actorSystem;

        public ActorSystemBuilder(ActorSystem actorSystem)
        {
            this.actorSystem = actorSystem;
        }

        public ServerActorsCollection AddRootActors()
        {
            var departments = this.actorSystem.ActorOf(this.actorSystem.DI().Props<OrganizationActor>(), "organization");
            var helpdesk = this.actorSystem.ActorOf(Props.Create(() => new HelpdeskActor()), "helpdesk");

            return new ServerActorsCollection(departments, helpdesk);
        }
    }
}